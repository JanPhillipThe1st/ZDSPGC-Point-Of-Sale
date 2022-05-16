using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ZDSPGC_Point_Of_Sale
{
    class Printer
    {
        private String reportName;
        private DataGridView reportData;
        int rowInt = 8;
        InputUtilities inputUtilities;
        Double totalSales = 0;
        int totalColumnInt=0;
        public Printer(String reportName, DataGridView dgvReports)
        {
            inputUtilities = new InputUtilities();
            this.reportName = reportName;
            this.reportData = dgvReports;
        }
       
        public void printReport()
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            _Workbook oWB;
            _Worksheet oSheet;
            Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = false;
                //Get a new workbook.
                oWB = (_Workbook)oXL.Workbooks.Add(Missing.Value);
                oSheet = (_Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                //Using HashMap to put cell data
                oSheet.Cells[1, 1] = "ZDSPGC Canteen\nPoint of Sale System";
                oSheet.Cells[3, 1] = reportName + " Report ";
                oSheet.Cells[4, 1] = Convert.ToString(" ====================================================================================");

                oSheet.get_Range("A1", "H1").Merge();
                oSheet.get_Range("A3", "H3").Merge();
                oSheet.get_Range("A4", "H4").Merge();
                String horizontalRule = " ==============";
                //Iterate through the datagrid view rows
                Range footerRange = oSheet.Cells[1, 1];
                //get column header using foreach
                int headerInt = 1;
                foreach (DataGridViewColumn column in reportData.Columns)
                {
                    oSheet.Cells[7, headerInt] = column.Name;
                    if (column.Name.Contains("Total"))
                    {
                        totalColumnInt = headerInt;
                    }
                    oSheet.Cells[7, headerInt].Font.Bold = true;
                    oSheet.Cells[7, headerInt].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    oSheet.Cells[7, headerInt].Borders.Weight = XlBorderWeight.xlThin;
                    oSheet.Cells[7, headerInt].Borders.LineStyle = XlLineStyle.xlContinuous;
                    headerInt++;
                    horizontalRule = horizontalRule + "=========";
                }
                //create an initial state variable

                //print each cell by multi threading
                try
                {
                    StartTheThread(oWB, oSheet).Start();
                    StartTheThread(oWB, oSheet).Join();
                }
                catch (Exception ex)
                {
                }
                //end


                oSheet.Cells[rowInt + 1, 1] = horizontalRule;



                oSheet.get_Range("A1:A6", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                //Format A1:D1 as bold, vertical alignment = center.

                Range c1 = oSheet.Cells[rowInt + 1, 1];
                Range c2 = oSheet.Cells[rowInt + 1, headerInt - 1];
                c1.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                c2.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                c1.VerticalAlignment = XlVAlign.xlVAlignCenter;
                c2.VerticalAlignment = XlVAlign.xlVAlignCenter;
                footerRange = (Range)oSheet.get_Range(c1, c2);
                footerRange.Merge();


                
                
                




                if (reportName.Contains("Sales"))
                {
                    oSheet.Cells[rowInt + 3, 1] = "Total Sales: " + totalSales;
                    oSheet.Cells[rowInt + 4, 1] = "Date Printed: " + DateTime.Now.ToString("MMMM dd, yyyy");
                    oSheet.Cells[rowInt + 5, 1] = "Time: " + DateTime.Now.ToString("t");
                    //scales down
                    oSheet.PageSetup.Zoom = 90;
                }
                else
                {
                    oSheet.Cells[rowInt + 3, 1] = "Date Printed: " + DateTime.Now.ToString("MMMM dd, yyyy");
                    oSheet.Cells[rowInt + 4, 1] = "Time: " + DateTime.Now.ToString("t");
                    oSheet.PageSetup.Zoom = 80;
                }
                oSheet.get_Range("A1:A3", Type.Missing).Font.Bold = true;

                oWB.PrintOutEx(1, 1, 2,false,1);
                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = false;
                MessageBox.Show(reportName + " Report Printed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception theException)
            {

                //MessageBox.Show(errorMessage, "Error");
            }

        }
        private void printTable(_Workbook oWB, _Worksheet oSheet)
        {
            rowInt = 8;
            var rowThread = new Thread(() => {
                foreach (DataGridViewRow row in reportData.Rows)
                {
                    var columnThread = new Thread(() => {
                        int columnInt = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            //check if report is inventory
                            //for formatting
                            if (columnInt == totalColumnInt)
                            {
                                totalSales += Convert.ToDouble(cell.Value);
                            }

                                oSheet.Cells[rowInt, columnInt] = Convert.ToString( cell.Value);
                            
                            oSheet.Cells[rowInt, columnInt].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                            oSheet.Cells[rowInt, columnInt].Borders.LineStyle = XlLineStyle.xlContinuous;
                            oSheet.Cells[rowInt, columnInt].Borders.Weight = XlBorderWeight.xlThin;
                            oSheet.Cells[rowInt, columnInt].EntireRow.AutoFit();
                            oSheet.Cells[rowInt, columnInt].EntireColumn.AutoFit();
                            oSheet.Cells[rowInt, columnInt].WrapText = true;
                            Thread.Sleep(2);
                            columnInt++;
                        }
                        rowInt++;
                    });
                    columnThread.Start();
                    columnThread.Join();
                }
            });
            rowThread.Start();
            rowThread.Join();


        }
        public Thread StartTheThread(_Workbook oWB, _Worksheet oSheet)
        {
            var t = new Thread(() => printTable(oWB, oSheet));
            t.Start();
            t.Join();
            return t;
        }
    }
}

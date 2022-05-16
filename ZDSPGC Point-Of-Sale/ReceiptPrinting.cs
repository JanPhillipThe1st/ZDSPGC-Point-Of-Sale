using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDSPGC_Point_Of_Sale
{
    class ReceiptPrinting
    {
        public String cashierName;
        public Double payment;
        public ReceiptPrinting(String cashierName,Double payment) {
            this.cashierName = cashierName;
            this.payment = payment;
        }
        public void printReceipt(String[] item, int[] quantitties, double[] itemAmount, String Orno)
        {
            Int32 totalQuantity = 0;
            Double Sales_total = 0;
            Int64 VATableSales = 0;
            Int64 Vat = 0;
            Int64 change = 0;

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
                oSheet.Cells[1, 1] = "ZDSPGC Canteen";
                oSheet.Cells[2, 1] = "Provinvial Capitol Compound, Pagadian City";
                oSheet.Cells[3, 1] = "Cashier: " + cashierName;
                oSheet.Cells[4, 1] = Convert.ToString(" ===================================================");
                oSheet.Cells[5, 1] = DateTime.Now.ToString("MM/dd/yyyy HH:mm") + "      OR# " + Orno;
                oSheet.Cells[7, 1] = " ===================================================";
                //Append sales transaction data to the excel worksheet
                int i = 8; // Cell row where the loop starts appending
                for (int j = 0; j < item.Length; j++)
                {
                    totalQuantity += quantitties[j];
                    oSheet.Cells[i, 1] = quantitties[j] + "  " + item[j];
                    oSheet.Cells[i, 4] = Math.Round(itemAmount[j], 2).ToString();
                    i++;
                    Sales_total += itemAmount[j];
                }
                //Display items on A column
                VATableSales = Convert.ToInt64(Sales_total / 1.12);
                Vat = Convert.ToInt64(Sales_total - VATableSales);
                change = Convert.ToInt64(payment - Sales_total);
                //footer texts
                oSheet.Cells[item.Length + 9, 1] = " ====================================================";
                oSheet.Cells[item.Length + 10, 1] = totalQuantity + "  Item(s)";
                //Display price on D column
                oSheet.Cells[item.Length + 10, 4] = Sales_total.ToString();
                oRng = (Range)oSheet.Cells[item.Length + 10, 4];
                oRng.HorizontalAlignment = XlHAlign.xlHAlignRight;
                //Display total due

                oSheet.Cells[item.Length + 12, 1] = "    Change";
                oSheet.Cells[item.Length + 12, 4] = change.ToString();
                oSheet.Cells[item.Length + 11, 1] = "    Cash";
                oSheet.Cells[item.Length + 11, 4] = payment.ToString();
                oSheet.Cells[item.Length + 18, 1] = "    Total Due:";
                oSheet.Cells[item.Length + 18, 1].Font.Bold = true;
                oSheet.Cells[item.Length + 18, 4] = Sales_total.ToString();
                oSheet.Cells[item.Length + 18, 4].Font.Bold = true;
                oSheet.Cells[item.Length + 16, 1] = "    VATable Sales";
                oSheet.Cells[item.Length + 16, 4] = VATableSales.ToString();
                oSheet.Cells[item.Length + 15, 1] = "    VAT Amount";
                oSheet.Cells[item.Length + 15, 4] = Vat.ToString();

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Merge();
                oSheet.get_Range("A2", "D2").Merge();
                oSheet.get_Range("A3", "D3").Merge();
                oSheet.get_Range("A4", "D4").Merge();
                oSheet.get_Range("A5", "D5").Merge();
                oSheet.get_Range("A7", "D7").Merge();
                oSheet.get_Range((Range)oSheet.Cells[item.Length + 9, 1], (Range)oSheet.Cells[item.Length + 9, 4]).Merge();
                oSheet.get_Range((Range)oSheet.Cells[item.Length + 9, 1], (Range)oSheet.Cells[item.Length + 9, 4]).HorizontalAlignment = XlHAlign.xlHAlignRight;
                oSheet.get_Range("A1:A1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A1:A1000", Type.Missing).EntireColumn.ColumnWidth = 25;
                oSheet.get_Range("A1:A3", Type.Missing).Font.Bold = true;


                oSheet.PrintOutEx(1, 1, 2, true);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = false;
                oXL.UserControl = true;


            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }



        public void printConsignmentReceipt(String barcode, String item, int quantitties, double itemPrice)
        {



            Microsoft.Office.Interop.Excel.Application oXL;
            _Workbook oWB;
            _Worksheet oSheet;
            Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (_Workbook)oXL.Workbooks.Add(Missing.Value);
                oSheet = (_Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                //Using HashMap to put cell data
                oSheet.Cells[1, 1] = "ZDSPGC Canteen";
                oSheet.Cells[2, 1] = "Provinvial Capitol Compound, Pagadian City";
                oSheet.Cells[4, 1] = Convert.ToString(" ===================================================");
                oSheet.Cells[5, 1] = "Date: ";
                oSheet.Cells[5, 2] = DateTime.Now.ToString("MMMM dd, yyyy");

                oSheet.Cells[6, 1] = "Time: ";
                oSheet.Cells[6, 2] = DateTime.Now.ToString("t");
                oSheet.Cells[7, 1] = "Quantity: ";
                oSheet.Cells[7, 2] = quantitties.ToString();
                oSheet.Cells[8, 1] = "Total: ";
                oSheet.Cells[8, 2] = (quantitties * itemPrice).ToString();

                oSheet.Cells[10, 1] = "Received by: ";
                oSheet.Cells[10, 2] = cashierName;

                //Append sales transaction data to the excel worksheet
                // Cell row where the loop starts appending


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Merge();
                oSheet.get_Range("A2", "D2").Merge();
                oSheet.get_Range("A4", "D4").Merge();
                oSheet.get_Range("B5", "D5").Merge();
                oSheet.get_Range("B6", "D6").Merge();
                oSheet.get_Range("B7", "D7").Merge();
                oSheet.get_Range("B8", "D8").Merge();
                oSheet.get_Range("B10", "D10").Merge();


                oSheet.get_Range("A1:A1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("B5:B1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oSheet.get_Range("B5:B1000", Type.Missing).Font.Bold = true;
                oSheet.get_Range("A1:A1000", Type.Missing).EntireColumn.ColumnWidth = 25;
                oSheet.get_Range("A1:A3", Type.Missing).Font.Bold = true;


                oSheet.PrintOutEx(1, 1, 2, true,1);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;


            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        public void printSoldConsignment(String barcode, String item, int soldQuantitties, double itemPrice, String supplier)
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
                oSheet.Cells[1, 1] = "ZDSPGC Canteen";
                oSheet.Cells[2, 1] = "Provinvial Capitol Compound, Pagadian City";
                oSheet.Cells[3, 1] = "Supplier: ";
                oSheet.Cells[3, 2] = supplier;
                oSheet.Cells[4, 1] = Convert.ToString(" ===================================================");
                oSheet.Cells[5, 1] = "Date: ";
                oSheet.Cells[5, 2] = DateTime.Now.ToString("MMMM dd, yyyy");

                oSheet.Cells[6, 1] = "Time: ";
                oSheet.Cells[6, 2] = DateTime.Now.ToString("t");
                oSheet.Cells[7, 1] = "Sold Quantity: ";
                oSheet.Cells[7, 2] = soldQuantitties.ToString();
                oSheet.Cells[8, 1] = "Total: ";
                oSheet.Cells[8, 2] = (soldQuantitties * itemPrice).ToString();

                oSheet.Cells[10, 1] = "Processed by: ";
                oSheet.Cells[10, 2] = cashierName;

                //Append sales transaction data to the excel worksheet
                // Cell row where the loop starts appending


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Merge();
                oSheet.get_Range("A4", "D4").Merge();
                oSheet.get_Range("B3", "D3").Merge();
                oSheet.get_Range("B5", "D5").Merge();
                oSheet.get_Range("B6", "D6").Merge();
                oSheet.get_Range("B7", "D7").Merge();
                oSheet.get_Range("A2", "D2").Merge();
                oSheet.get_Range("B8", "D8").Merge();
                oSheet.get_Range("B10", "D10").Merge();

                oSheet.get_Range("A1:A1", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A2:A2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A3:A1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                oSheet.get_Range("B5:B1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oSheet.get_Range("B5:B1000", Type.Missing).Font.Bold = true;
                oSheet.get_Range("B3:B3", Type.Missing).Font.Bold = true;
                oSheet.get_Range("A3:A3", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                oSheet.get_Range("A3:A3", Type.Missing).Font.Bold = false;
                oSheet.get_Range("A1:A1000", Type.Missing).EntireColumn.ColumnWidth = 25;
                oSheet.get_Range("A1:A3", Type.Missing).Font.Bold = true;


                oSheet.PrintOutEx(1, 1, 2, true,1);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;


            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }


        public void printUnsoldConsignment(String barcode, String item, int soldQuantitties, double itemPrice, String supplier)
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
                oSheet.Cells[1, 1] = "ZDSPGC Canteen";
                oSheet.Cells[2, 1] = "Provinvial Capitol Compound, Pagadian City";
                oSheet.Cells[3, 1] = "Supplier: ";
                oSheet.Cells[3, 2] = supplier;
                oSheet.Cells[4, 1] = Convert.ToString(" ===================================================");
                oSheet.Cells[5, 1] = "Date: ";
                oSheet.Cells[5, 2] = DateTime.Now.ToString("MMMM dd, yyyy");

                oSheet.Cells[6, 1] = "Time: ";
                oSheet.Cells[6, 2] = DateTime.Now.ToString("t");
                oSheet.Cells[7, 1] = "Sold Quantity: ";
                oSheet.Cells[7, 2] = "0";
                oSheet.Cells[8, 1] = "Returned from Supplier: ";
                oSheet.Cells[8, 2] = (soldQuantitties * itemPrice).ToString();

                oSheet.Cells[10, 1] = "Processed by: ";
                oSheet.Cells[10, 2] = cashierName;

                //Append sales transaction data to the excel worksheet
                // Cell row where the loop starts appending


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Merge();
                oSheet.get_Range("A4", "D4").Merge();
                oSheet.get_Range("B3", "D3").Merge();
                oSheet.get_Range("B5", "D5").Merge();
                oSheet.get_Range("B6", "D6").Merge();
                oSheet.get_Range("B7", "D7").Merge();
                oSheet.get_Range("A2", "D2").Merge();
                oSheet.get_Range("B8", "D8").Merge();
                oSheet.get_Range("B10", "D10").Merge();

                oSheet.get_Range("A1:A1", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A2:A2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A3:A1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                oSheet.get_Range("B5:B1000", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oSheet.get_Range("B5:B1000", Type.Missing).Font.Bold = true;
                oSheet.get_Range("B3:B3", Type.Missing).Font.Bold = true;
                oSheet.get_Range("A3:A3", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                oSheet.get_Range("A3:A3", Type.Missing).Font.Bold = false;
                oSheet.get_Range("A1:A1000", Type.Missing).EntireColumn.ColumnWidth = 25;
                oSheet.get_Range("A1:A3", Type.Missing).Font.Bold = true;


                oSheet.PrintOutEx(1, 1, 2, true,1);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;


            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        public void setPayment(double payment1)
        {
            payment = payment1;
        }
    }
}

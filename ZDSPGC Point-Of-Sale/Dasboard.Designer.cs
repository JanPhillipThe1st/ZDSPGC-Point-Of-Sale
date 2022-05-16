
namespace ZDSPGC_Point_Of_Sale
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDailySales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLowStockProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintSalesReport = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDailySales
            // 
            this.dgvDailySales.AllowUserToAddRows = false;
            this.dgvDailySales.AllowUserToDeleteRows = false;
            this.dgvDailySales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDailySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySales.Location = new System.Drawing.Point(20, 76);
            this.dgvDailySales.MultiSelect = false;
            this.dgvDailySales.Name = "dgvDailySales";
            this.dgvDailySales.ReadOnly = true;
            this.dgvDailySales.RowHeadersVisible = false;
            this.dgvDailySales.RowHeadersWidth = 51;
            this.dgvDailySales.RowTemplate.Height = 24;
            this.dgvDailySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailySales.Size = new System.Drawing.Size(850, 624);
            this.dgvDailySales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Sales";
            // 
            // dgvLowStockProducts
            // 
            this.dgvLowStockProducts.AllowUserToAddRows = false;
            this.dgvLowStockProducts.AllowUserToDeleteRows = false;
            this.dgvLowStockProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLowStockProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStockProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStockProducts.Location = new System.Drawing.Point(884, 76);
            this.dgvLowStockProducts.MultiSelect = false;
            this.dgvLowStockProducts.Name = "dgvLowStockProducts";
            this.dgvLowStockProducts.ReadOnly = true;
            this.dgvLowStockProducts.RowHeadersVisible = false;
            this.dgvLowStockProducts.RowHeadersWidth = 51;
            this.dgvLowStockProducts.RowTemplate.Height = 24;
            this.dgvLowStockProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStockProducts.Size = new System.Drawing.Size(376, 624);
            this.dgvLowStockProducts.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(876, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Low-Stock Products";
            // 
            // btnPrintSalesReport
            // 
            this.btnPrintSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnPrintSalesReport.FlatAppearance.BorderSize = 0;
            this.btnPrintSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalesReport.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintSalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintSalesReport.Location = new System.Drawing.Point(20, 720);
            this.btnPrintSalesReport.Name = "btnPrintSalesReport";
            this.btnPrintSalesReport.Size = new System.Drawing.Size(321, 47);
            this.btnPrintSalesReport.TabIndex = 2;
            this.btnPrintSalesReport.Text = "Print Report";
            this.btnPrintSalesReport.UseVisualStyleBackColor = false;
            this.btnPrintSalesReport.Click += new System.EventHandler(this.btnPrintSalesReport_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTotalSales.Location = new System.Drawing.Point(410, 734);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(157, 39);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "Total Sales:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1425, 779);
            this.Controls.Add(this.btnPrintSalesReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLowStockProducts);
            this.Controls.Add(this.dgvDailySales);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDailySales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLowStockProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintSalesReport;
        private System.Windows.Forms.Label lblTotalSales;
    }
}
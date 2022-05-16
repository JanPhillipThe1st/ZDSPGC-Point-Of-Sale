
namespace ZDSPGC_Point_Of_Sale
{
    partial class Consignments
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
            this.label12 = new System.Windows.Forms.Label();
            this.dgvConsignments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label12.Location = new System.Drawing.Point(882, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "Double-Click on Record to return*";
            // 
            // dgvConsignments
            // 
            this.dgvConsignments.AllowUserToAddRows = false;
            this.dgvConsignments.AllowUserToDeleteRows = false;
            this.dgvConsignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsignments.Location = new System.Drawing.Point(24, 71);
            this.dgvConsignments.MultiSelect = false;
            this.dgvConsignments.Name = "dgvConsignments";
            this.dgvConsignments.ReadOnly = true;
            this.dgvConsignments.RowHeadersVisible = false;
            this.dgvConsignments.RowHeadersWidth = 51;
            this.dgvConsignments.RowTemplate.Height = 24;
            this.dgvConsignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsignments.Size = new System.Drawing.Size(1204, 499);
            this.dgvConsignments.TabIndex = 2;
            this.dgvConsignments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsignments_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consignments";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Comfortaa", 14F);
            this.lblProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblProfit.Location = new System.Drawing.Point(905, 573);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(156, 39);
            this.lblProfit.TabIndex = 3;
            this.lblProfit.Text = "Total Profit:";
            // 
            // Consignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1247, 746);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsignments);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Consignments";
            this.Text = "Consigments";
            this.Load += new System.EventHandler(this.Consignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvConsignments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfit;
    }
}
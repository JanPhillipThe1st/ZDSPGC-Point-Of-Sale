
namespace ZDSPGC_Point_Of_Sale
{
    partial class Credit
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
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(813, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "* Press F5 to Confirm Sale";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label12.Location = new System.Drawing.Point(802, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(425, 30);
            this.label12.TabIndex = 16;
            this.label12.Text = "Double-Click on Record to update/delete*";
            // 
            // itemTotal
            // 
            this.itemTotal.HeaderText = "Total";
            this.itemTotal.MinimumWidth = 6;
            this.itemTotal.Name = "itemTotal";
            this.itemTotal.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.MinimumWidth = 6;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Unit Price";
            this.itemPrice.MinimumWidth = 6;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Description";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemBarcode
            // 
            this.itemBarcode.HeaderText = "Barcode";
            this.itemBarcode.MinimumWidth = 6;
            this.itemBarcode.Name = "itemBarcode";
            this.itemBarcode.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(150, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(322, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.cbCustomer);
            this.gbTransaction.Controls.Add(this.tbQuantity);
            this.gbTransaction.Controls.Add(this.label5);
            this.gbTransaction.Controls.Add(this.tbUnitPrice);
            this.gbTransaction.Controls.Add(this.label4);
            this.gbTransaction.Controls.Add(this.tbBarcode);
            this.gbTransaction.Controls.Add(this.label3);
            this.gbTransaction.Controls.Add(this.tbItemDescription);
            this.gbTransaction.Controls.Add(this.label8);
            this.gbTransaction.Controls.Add(this.label1);
            this.gbTransaction.Controls.Add(this.btnAdd);
            this.gbTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbTransaction.Location = new System.Drawing.Point(12, 12);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(622, 348);
            this.gbTransaction.TabIndex = 14;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Credit";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(202, 242);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(370, 36);
            this.cbCustomer.TabIndex = 6;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Enabled = false;
            this.tbQuantity.Location = new System.Drawing.Point(202, 193);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(370, 30);
            this.tbQuantity.TabIndex = 4;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(82, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Enabled = false;
            this.tbUnitPrice.Location = new System.Drawing.Point(202, 145);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(370, 30);
            this.tbUnitPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(120, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(202, 98);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(370, 30);
            this.tbBarcode.TabIndex = 2;
            this.tbBarcode.TextChanged += new System.EventHandler(this.tbBarcode_TextChanged);
            this.tbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(86, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barcode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Enabled = false;
            this.tbItemDescription.Location = new System.Drawing.Point(202, 52);
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(370, 30);
            this.tbItemDescription.TabIndex = 1;
            this.tbItemDescription.TextChanged += new System.EventHandler(this.tbItemDescription_TextChanged);
            this.tbItemDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbItemDescription_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(71, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Customer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemBarcode,
            this.itemName,
            this.itemPrice,
            this.itemQuantity,
            this.itemTotal});
            this.dgvItems.Location = new System.Drawing.Point(23, 403);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1204, 242);
            this.dgvItems.TabIndex = 9;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnConfirmSale.FlatAppearance.BorderSize = 0;
            this.btnConfirmSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSale.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmSale.Location = new System.Drawing.Point(23, 651);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(322, 40);
            this.btnConfirmSale.TabIndex = 10;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = false;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.lblTotal.Location = new System.Drawing.Point(1027, 655);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 34);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "100.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(745, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transaction Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(15, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Items";
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Credit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBarcode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCustomer;
    }
}
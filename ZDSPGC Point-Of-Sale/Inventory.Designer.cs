
namespace ZDSPGC_Point_Of_Sale
{
    partial class Inventory
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
            this.gbUpdateItem = new System.Windows.Forms.GroupBox();
            this.cbUpdateUnit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbUpdateRemainingQuantity = new System.Windows.Forms.TextBox();
            this.tbUpdateQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUpdateBarcode = new System.Windows.Forms.TextBox();
            this.tbUpdateItemDescription = new System.Windows.Forms.TextBox();
            this.tbUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpdateOriginalPrice = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOriginalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAddItem = new System.Windows.Forms.GroupBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAddToConsignment = new System.Windows.Forms.Button();
            this.gbUpdateItem.SuspendLayout();
            this.gbAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUpdateItem
            // 
            this.gbUpdateItem.Controls.Add(this.cbUpdateUnit);
            this.gbUpdateItem.Controls.Add(this.label14);
            this.gbUpdateItem.Controls.Add(this.btnDelete);
            this.gbUpdateItem.Controls.Add(this.btnConfirm);
            this.gbUpdateItem.Controls.Add(this.tbUpdateRemainingQuantity);
            this.gbUpdateItem.Controls.Add(this.tbUpdateQuantity);
            this.gbUpdateItem.Controls.Add(this.label16);
            this.gbUpdateItem.Controls.Add(this.label17);
            this.gbUpdateItem.Controls.Add(this.label7);
            this.gbUpdateItem.Controls.Add(this.label10);
            this.gbUpdateItem.Controls.Add(this.tbUpdateBarcode);
            this.gbUpdateItem.Controls.Add(this.tbUpdateItemDescription);
            this.gbUpdateItem.Controls.Add(this.tbUpdateUnitPrice);
            this.gbUpdateItem.Controls.Add(this.label8);
            this.gbUpdateItem.Controls.Add(this.label9);
            this.gbUpdateItem.Controls.Add(this.tbUpdateOriginalPrice);
            this.gbUpdateItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbUpdateItem.Location = new System.Drawing.Point(653, 273);
            this.gbUpdateItem.Name = "gbUpdateItem";
            this.gbUpdateItem.Size = new System.Drawing.Size(557, 467);
            this.gbUpdateItem.TabIndex = 8;
            this.gbUpdateItem.TabStop = false;
            this.gbUpdateItem.Text = "Update Item";
            this.gbUpdateItem.Enter += new System.EventHandler(this.gbUpdateItem_Enter);
            // 
            // cbUpdateUnit
            // 
            this.cbUpdateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateUnit.Enabled = false;
            this.cbUpdateUnit.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.cbUpdateUnit.FormattingEnabled = true;
            this.cbUpdateUnit.Location = new System.Drawing.Point(218, 116);
            this.cbUpdateUnit.Name = "cbUpdateUnit";
            this.cbUpdateUnit.Size = new System.Drawing.Size(306, 36);
            this.cbUpdateUnit.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(157, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "Unit";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(131, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(322, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.Location = new System.Drawing.Point(131, 364);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(322, 40);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Update Item";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbUpdateRemainingQuantity
            // 
            this.tbUpdateRemainingQuantity.Enabled = false;
            this.tbUpdateRemainingQuantity.Location = new System.Drawing.Point(218, 279);
            this.tbUpdateRemainingQuantity.Name = "tbUpdateRemainingQuantity";
            this.tbUpdateRemainingQuantity.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateRemainingQuantity.TabIndex = 2;
            this.tbUpdateRemainingQuantity.TextChanged += new System.EventHandler(this.tbUpdateQuantity_TextChanged);
            // 
            // tbUpdateQuantity
            // 
            this.tbUpdateQuantity.Enabled = false;
            this.tbUpdateQuantity.Location = new System.Drawing.Point(218, 238);
            this.tbUpdateQuantity.Name = "tbUpdateQuantity";
            this.tbUpdateQuantity.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateQuantity.TabIndex = 2;
            this.tbUpdateQuantity.TextChanged += new System.EventHandler(this.tbUpdateQuantity_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label16.Location = new System.Drawing.Point(116, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "Barcode";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label17.Location = new System.Drawing.Point(67, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 30);
            this.label17.TabIndex = 1;
            this.label17.Text = "Add Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(36, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label10.Location = new System.Drawing.Point(112, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantity";
            // 
            // tbUpdateBarcode
            // 
            this.tbUpdateBarcode.Enabled = false;
            this.tbUpdateBarcode.Location = new System.Drawing.Point(218, 39);
            this.tbUpdateBarcode.Name = "tbUpdateBarcode";
            this.tbUpdateBarcode.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateBarcode.TabIndex = 2;
            // 
            // tbUpdateItemDescription
            // 
            this.tbUpdateItemDescription.Enabled = false;
            this.tbUpdateItemDescription.Location = new System.Drawing.Point(218, 75);
            this.tbUpdateItemDescription.Name = "tbUpdateItemDescription";
            this.tbUpdateItemDescription.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateItemDescription.TabIndex = 2;
            // 
            // tbUpdateUnitPrice
            // 
            this.tbUpdateUnitPrice.Enabled = false;
            this.tbUpdateUnitPrice.Location = new System.Drawing.Point(218, 202);
            this.tbUpdateUnitPrice.Name = "tbUpdateUnitPrice";
            this.tbUpdateUnitPrice.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateUnitPrice.TabIndex = 2;
            this.tbUpdateUnitPrice.TextChanged += new System.EventHandler(this.tbUpdateUnitPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(64, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Original Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label9.Location = new System.Drawing.Point(102, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Unit Price";
            // 
            // tbUpdateOriginalPrice
            // 
            this.tbUpdateOriginalPrice.Enabled = false;
            this.tbUpdateOriginalPrice.Location = new System.Drawing.Point(218, 162);
            this.tbUpdateOriginalPrice.Name = "tbUpdateOriginalPrice";
            this.tbUpdateOriginalPrice.Size = new System.Drawing.Size(306, 30);
            this.tbUpdateOriginalPrice.TabIndex = 2;
            this.tbUpdateOriginalPrice.TextChanged += new System.EventHandler(this.tbUpdateOriginalPrice_TextChanged);
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(211, 130);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(370, 36);
            this.cbUnit.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label13.Location = new System.Drawing.Point(136, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Unit";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(211, 261);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(370, 30);
            this.tbQuantity.TabIndex = 2;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(91, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(211, 218);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(370, 30);
            this.tbUnitPrice.TabIndex = 2;
            this.tbUnitPrice.TextChanged += new System.EventHandler(this.tbUnitPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(81, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOriginalPrice
            // 
            this.tbOriginalPrice.Location = new System.Drawing.Point(211, 178);
            this.tbOriginalPrice.Name = "tbOriginalPrice";
            this.tbOriginalPrice.Size = new System.Drawing.Size(370, 30);
            this.tbOriginalPrice.TabIndex = 2;
            this.tbOriginalPrice.TextChanged += new System.EventHandler(this.tbOriginalPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(43, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Original Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Location = new System.Drawing.Point(211, 89);
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(370, 30);
            this.tbItemDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(176, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(322, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbAddItem
            // 
            this.gbAddItem.Controls.Add(this.cbUnit);
            this.gbAddItem.Controls.Add(this.label13);
            this.gbAddItem.Controls.Add(this.tbQuantity);
            this.gbAddItem.Controls.Add(this.label5);
            this.gbAddItem.Controls.Add(this.tbUnitPrice);
            this.gbAddItem.Controls.Add(this.label4);
            this.gbAddItem.Controls.Add(this.tbOriginalPrice);
            this.gbAddItem.Controls.Add(this.label3);
            this.gbAddItem.Controls.Add(this.tbBarcode);
            this.gbAddItem.Controls.Add(this.label15);
            this.gbAddItem.Controls.Add(this.tbItemDescription);
            this.gbAddItem.Controls.Add(this.label1);
            this.gbAddItem.Controls.Add(this.btnAddToConsignment);
            this.gbAddItem.Controls.Add(this.btnAdd);
            this.gbAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddItem.Location = new System.Drawing.Point(20, 273);
            this.gbAddItem.Name = "gbAddItem";
            this.gbAddItem.Size = new System.Drawing.Size(597, 461);
            this.gbAddItem.TabIndex = 9;
            this.gbAddItem.TabStop = false;
            this.gbAddItem.Text = "Add Item";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(211, 44);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(370, 30);
            this.tbBarcode.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label15.Location = new System.Drawing.Point(95, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "Barcode";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label12.Location = new System.Drawing.Point(799, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(425, 30);
            this.label12.TabIndex = 6;
            this.label12.Text = "Double-Click on Record to update/delete*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Items";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(20, 68);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1204, 179);
            this.dgvItems.TabIndex = 5;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // btnAddToConsignment
            // 
            this.btnAddToConsignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAddToConsignment.FlatAppearance.BorderSize = 0;
            this.btnAddToConsignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToConsignment.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToConsignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddToConsignment.Location = new System.Drawing.Point(176, 379);
            this.btnAddToConsignment.Name = "btnAddToConsignment";
            this.btnAddToConsignment.Size = new System.Drawing.Size(322, 40);
            this.btnAddToConsignment.TabIndex = 0;
            this.btnAddToConsignment.Text = "Add Item as Consignment";
            this.btnAddToConsignment.UseVisualStyleBackColor = false;
            this.btnAddToConsignment.Click += new System.EventHandler(this.btnAddToConsignment_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1247, 746);
            this.Controls.Add(this.gbUpdateItem);
            this.Controls.Add(this.gbAddItem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvItems);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.gbUpdateItem.ResumeLayout(false);
            this.gbUpdateItem.PerformLayout();
            this.gbAddItem.ResumeLayout(false);
            this.gbAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdateItem;
        private System.Windows.Forms.ComboBox cbUpdateUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbUpdateQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUpdateItemDescription;
        private System.Windows.Forms.TextBox tbUpdateUnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUpdateOriginalPrice;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOriginalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAddItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbUpdateBarcode;
        private System.Windows.Forms.TextBox tbUpdateRemainingQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddToConsignment;
    }
}
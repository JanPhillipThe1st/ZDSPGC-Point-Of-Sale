
namespace ZDSPGC_Point_Of_Sale
{
    partial class Settings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tcStaff = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.gbUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.tbUpdateCustomerAddress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.tbUpdateCustomeContact = new System.Windows.Forms.TextBox();
            this.tbUpdateCustomerName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbCustomerContact = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.gbUpdateSupplier = new System.Windows.Forms.GroupBox();
            this.tbUpdateSupplierAddress = new System.Windows.Forms.TextBox();
            this.btnDeleteSupplierInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSupplierInformation = new System.Windows.Forms.Button();
            this.tbUpdateSupplierContact = new System.Windows.Forms.TextBox();
            this.tbUpdateSupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAddSupplier = new System.Windows.Forms.GroupBox();
            this.tbSupplierAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSupplierContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpUnit = new System.Windows.Forms.TabPage();
            this.gbUpdateUnit = new System.Windows.Forms.GroupBox();
            this.tbUpdateUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnUpdateUnit = new System.Windows.Forms.Button();
            this.gbAddUnit = new System.Windows.Forms.GroupBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tcStaff.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.gbUpdateCustomer.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageSupplier.SuspendLayout();
            this.gbUpdateSupplier.SuspendLayout();
            this.gbAddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tpUnit.SuspendLayout();
            this.gbUpdateUnit.SuspendLayout();
            this.gbAddUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(88)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClose.Location = new System.Drawing.Point(1355, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 48);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcStaff
            // 
            this.tcStaff.Controls.Add(this.tabPageCustomer);
            this.tcStaff.Controls.Add(this.tabPageSupplier);
            this.tcStaff.Controls.Add(this.tpUnit);
            this.tcStaff.Location = new System.Drawing.Point(92, 81);
            this.tcStaff.Name = "tcStaff";
            this.tcStaff.SelectedIndex = 0;
            this.tcStaff.Size = new System.Drawing.Size(1205, 696);
            this.tcStaff.TabIndex = 13;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPageCustomer.Controls.Add(this.gbUpdateCustomer);
            this.tabPageCustomer.Controls.Add(this.gbAddCustomer);
            this.tabPageCustomer.Controls.Add(this.dgvCustomers);
            this.tabPageCustomer.Controls.Add(this.label31);
            this.tabPageCustomer.Controls.Add(this.label32);
            this.tabPageCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 42);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(1197, 650);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.Click += new System.EventHandler(this.tabPageCustomer_Click);
            // 
            // gbUpdateCustomer
            // 
            this.gbUpdateCustomer.Controls.Add(this.tbUpdateCustomerAddress);
            this.gbUpdateCustomer.Controls.Add(this.label19);
            this.gbUpdateCustomer.Controls.Add(this.btnUpdateCustomer);
            this.gbUpdateCustomer.Controls.Add(this.tbUpdateCustomeContact);
            this.gbUpdateCustomer.Controls.Add(this.tbUpdateCustomerName);
            this.gbUpdateCustomer.Controls.Add(this.label18);
            this.gbUpdateCustomer.Controls.Add(this.label17);
            this.gbUpdateCustomer.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbUpdateCustomer.Location = new System.Drawing.Point(600, 20);
            this.gbUpdateCustomer.Name = "gbUpdateCustomer";
            this.gbUpdateCustomer.Size = new System.Drawing.Size(560, 397);
            this.gbUpdateCustomer.TabIndex = 15;
            this.gbUpdateCustomer.TabStop = false;
            this.gbUpdateCustomer.Text = "Update Customer Information";
            // 
            // tbUpdateCustomerAddress
            // 
            this.tbUpdateCustomerAddress.Enabled = false;
            this.tbUpdateCustomerAddress.Location = new System.Drawing.Point(159, 229);
            this.tbUpdateCustomerAddress.Name = "tbUpdateCustomerAddress";
            this.tbUpdateCustomerAddress.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateCustomerAddress.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label19.Location = new System.Drawing.Point(38, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "Address";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnUpdateCustomer.Enabled = false;
            this.btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(101, 299);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(367, 40);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update Customer Information";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // tbUpdateCustomeContact
            // 
            this.tbUpdateCustomeContact.Enabled = false;
            this.tbUpdateCustomeContact.Location = new System.Drawing.Point(159, 169);
            this.tbUpdateCustomeContact.Name = "tbUpdateCustomeContact";
            this.tbUpdateCustomeContact.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateCustomeContact.TabIndex = 4;
            // 
            // tbUpdateCustomerName
            // 
            this.tbUpdateCustomerName.Enabled = false;
            this.tbUpdateCustomerName.Location = new System.Drawing.Point(159, 109);
            this.tbUpdateCustomerName.Name = "tbUpdateCustomerName";
            this.tbUpdateCustomerName.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateCustomerName.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label18.Location = new System.Drawing.Point(38, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 30);
            this.label18.TabIndex = 1;
            this.label18.Text = "Contact";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label17.Location = new System.Drawing.Point(59, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 30);
            this.label17.TabIndex = 1;
            this.label17.Text = "Name";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.Controls.Add(this.tbCustomerAddress);
            this.gbAddCustomer.Controls.Add(this.label24);
            this.gbAddCustomer.Controls.Add(this.tbCustomerContact);
            this.gbAddCustomer.Controls.Add(this.label26);
            this.gbAddCustomer.Controls.Add(this.tbCustomerName);
            this.gbAddCustomer.Controls.Add(this.label30);
            this.gbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.gbAddCustomer.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddCustomer.Location = new System.Drawing.Point(10, 20);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(560, 371);
            this.gbAddCustomer.TabIndex = 16;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add Customer";
            this.gbAddCustomer.Enter += new System.EventHandler(this.gbAddCustomer_Enter);
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(159, 174);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(370, 30);
            this.tbCustomerAddress.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label24.Location = new System.Drawing.Point(38, 174);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 30);
            this.label24.TabIndex = 1;
            this.label24.Text = "Address";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomerContact
            // 
            this.tbCustomerContact.Location = new System.Drawing.Point(159, 234);
            this.tbCustomerContact.Name = "tbCustomerContact";
            this.tbCustomerContact.Size = new System.Drawing.Size(370, 30);
            this.tbCustomerContact.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label26.Location = new System.Drawing.Point(38, 234);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 30);
            this.label26.TabIndex = 1;
            this.label26.Text = "Contact";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(159, 114);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(370, 30);
            this.tbCustomerName.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label30.Location = new System.Drawing.Point(59, 114);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 30);
            this.label30.TabIndex = 1;
            this.label30.Text = "Name";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(138, 315);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(322, 40);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(24, 451);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1162, 178);
            this.dgvCustomers.TabIndex = 12;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label31.Location = new System.Drawing.Point(792, 420);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(394, 28);
            this.label31.TabIndex = 13;
            this.label31.Text = "Double-Click on a record to update/delete*";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Comfortaa", 14F);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label32.Location = new System.Drawing.Point(17, 409);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(152, 39);
            this.label32.TabIndex = 14;
            this.label32.Text = "Customers";
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPageSupplier.Controls.Add(this.gbUpdateSupplier);
            this.tabPageSupplier.Controls.Add(this.gbAddSupplier);
            this.tabPageSupplier.Controls.Add(this.dgvSupplier);
            this.tabPageSupplier.Controls.Add(this.label7);
            this.tabPageSupplier.Controls.Add(this.label8);
            this.tabPageSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 42);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(1197, 650);
            this.tabPageSupplier.TabIndex = 1;
            this.tabPageSupplier.Text = "Supplier";
            this.tabPageSupplier.Click += new System.EventHandler(this.tabPageSupplier_Click);
            // 
            // gbUpdateSupplier
            // 
            this.gbUpdateSupplier.Controls.Add(this.tbUpdateSupplierAddress);
            this.gbUpdateSupplier.Controls.Add(this.btnDeleteSupplierInformation);
            this.gbUpdateSupplier.Controls.Add(this.label1);
            this.gbUpdateSupplier.Controls.Add(this.btnUpdateSupplierInformation);
            this.gbUpdateSupplier.Controls.Add(this.tbUpdateSupplierContact);
            this.gbUpdateSupplier.Controls.Add(this.tbUpdateSupplierName);
            this.gbUpdateSupplier.Controls.Add(this.label2);
            this.gbUpdateSupplier.Controls.Add(this.label3);
            this.gbUpdateSupplier.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbUpdateSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbUpdateSupplier.Location = new System.Drawing.Point(600, 20);
            this.gbUpdateSupplier.Name = "gbUpdateSupplier";
            this.gbUpdateSupplier.Size = new System.Drawing.Size(560, 397);
            this.gbUpdateSupplier.TabIndex = 20;
            this.gbUpdateSupplier.TabStop = false;
            this.gbUpdateSupplier.Text = "Update Customer Information";
            // 
            // tbUpdateSupplierAddress
            // 
            this.tbUpdateSupplierAddress.Enabled = false;
            this.tbUpdateSupplierAddress.Location = new System.Drawing.Point(159, 169);
            this.tbUpdateSupplierAddress.Name = "tbUpdateSupplierAddress";
            this.tbUpdateSupplierAddress.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateSupplierAddress.TabIndex = 4;
            // 
            // btnDeleteSupplierInformation
            // 
            this.btnDeleteSupplierInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDeleteSupplierInformation.Enabled = false;
            this.btnDeleteSupplierInformation.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupplierInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplierInformation.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplierInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteSupplierInformation.Location = new System.Drawing.Point(81, 345);
            this.btnDeleteSupplierInformation.Name = "btnDeleteSupplierInformation";
            this.btnDeleteSupplierInformation.Size = new System.Drawing.Size(405, 40);
            this.btnDeleteSupplierInformation.TabIndex = 5;
            this.btnDeleteSupplierInformation.Text = "Delete Supplier Information";
            this.btnDeleteSupplierInformation.UseVisualStyleBackColor = false;
            this.btnDeleteSupplierInformation.Click += new System.EventHandler(this.btnDeleteSupplierInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(38, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateSupplierInformation
            // 
            this.btnUpdateSupplierInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnUpdateSupplierInformation.Enabled = false;
            this.btnUpdateSupplierInformation.FlatAppearance.BorderSize = 0;
            this.btnUpdateSupplierInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplierInformation.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplierInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateSupplierInformation.Location = new System.Drawing.Point(101, 299);
            this.btnUpdateSupplierInformation.Name = "btnUpdateSupplierInformation";
            this.btnUpdateSupplierInformation.Size = new System.Drawing.Size(367, 40);
            this.btnUpdateSupplierInformation.TabIndex = 5;
            this.btnUpdateSupplierInformation.Text = "Update Supplier Information";
            this.btnUpdateSupplierInformation.UseVisualStyleBackColor = false;
            this.btnUpdateSupplierInformation.Click += new System.EventHandler(this.btnUpdateSupplierInformation_Click);
            // 
            // tbUpdateSupplierContact
            // 
            this.tbUpdateSupplierContact.Enabled = false;
            this.tbUpdateSupplierContact.Location = new System.Drawing.Point(159, 229);
            this.tbUpdateSupplierContact.Name = "tbUpdateSupplierContact";
            this.tbUpdateSupplierContact.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateSupplierContact.TabIndex = 4;
            // 
            // tbUpdateSupplierName
            // 
            this.tbUpdateSupplierName.Enabled = false;
            this.tbUpdateSupplierName.Location = new System.Drawing.Point(159, 109);
            this.tbUpdateSupplierName.Name = "tbUpdateSupplierName";
            this.tbUpdateSupplierName.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateSupplierName.TabIndex = 4;
            this.tbUpdateSupplierName.TextChanged += new System.EventHandler(this.tbUpdateSupplierName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(38, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAddSupplier
            // 
            this.gbAddSupplier.Controls.Add(this.tbSupplierAddress);
            this.gbAddSupplier.Controls.Add(this.label4);
            this.gbAddSupplier.Controls.Add(this.tbSupplierContact);
            this.gbAddSupplier.Controls.Add(this.label5);
            this.gbAddSupplier.Controls.Add(this.tbSupplierName);
            this.gbAddSupplier.Controls.Add(this.label6);
            this.gbAddSupplier.Controls.Add(this.btnAddSupplier);
            this.gbAddSupplier.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddSupplier.Location = new System.Drawing.Point(10, 20);
            this.gbAddSupplier.Name = "gbAddSupplier";
            this.gbAddSupplier.Size = new System.Drawing.Size(560, 371);
            this.gbAddSupplier.TabIndex = 21;
            this.gbAddSupplier.TabStop = false;
            this.gbAddSupplier.Text = "Add Supplier";
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Location = new System.Drawing.Point(159, 174);
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.Size = new System.Drawing.Size(370, 30);
            this.tbSupplierAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(38, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSupplierContact
            // 
            this.tbSupplierContact.Location = new System.Drawing.Point(159, 234);
            this.tbSupplierContact.Name = "tbSupplierContact";
            this.tbSupplierContact.Size = new System.Drawing.Size(370, 30);
            this.tbSupplierContact.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(38, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Contact";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(159, 114);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(370, 30);
            this.tbSupplierName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(59, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddSupplier.Location = new System.Drawing.Point(138, 315);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(322, 40);
            this.btnAddSupplier.TabIndex = 5;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(24, 451);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.Height = 24;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(1162, 394);
            this.dgvSupplier.TabIndex = 17;
            this.dgvSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(792, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Double-Click on a record to update/delete*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comfortaa", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(17, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Suppliers";
            // 
            // tpUnit
            // 
            this.tpUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tpUnit.Controls.Add(this.gbUpdateUnit);
            this.tpUnit.Controls.Add(this.gbAddUnit);
            this.tpUnit.Controls.Add(this.dgvUnit);
            this.tpUnit.Controls.Add(this.label15);
            this.tpUnit.Controls.Add(this.label16);
            this.tpUnit.Location = new System.Drawing.Point(4, 42);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Size = new System.Drawing.Size(1197, 650);
            this.tpUnit.TabIndex = 2;
            this.tpUnit.Text = "Unit";
            this.tpUnit.Click += new System.EventHandler(this.tpUnit_Click);
            // 
            // gbUpdateUnit
            // 
            this.gbUpdateUnit.Controls.Add(this.tbUpdateUnit);
            this.gbUpdateUnit.Controls.Add(this.label9);
            this.gbUpdateUnit.Controls.Add(this.btnDeleteUnit);
            this.gbUpdateUnit.Controls.Add(this.btnUpdateUnit);
            this.gbUpdateUnit.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbUpdateUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbUpdateUnit.Location = new System.Drawing.Point(600, 20);
            this.gbUpdateUnit.Name = "gbUpdateUnit";
            this.gbUpdateUnit.Size = new System.Drawing.Size(560, 265);
            this.gbUpdateUnit.TabIndex = 20;
            this.gbUpdateUnit.TabStop = false;
            this.gbUpdateUnit.Text = "Update Unit";
            // 
            // tbUpdateUnit
            // 
            this.tbUpdateUnit.Location = new System.Drawing.Point(159, 66);
            this.tbUpdateUnit.Name = "tbUpdateUnit";
            this.tbUpdateUnit.Size = new System.Drawing.Size(370, 30);
            this.tbUpdateUnit.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label9.Location = new System.Drawing.Point(59, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Unit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDeleteUnit.Enabled = false;
            this.btnDeleteUnit.FlatAppearance.BorderSize = 0;
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUnit.Location = new System.Drawing.Point(81, 190);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(405, 40);
            this.btnDeleteUnit.TabIndex = 5;
            this.btnDeleteUnit.Text = "Delete Unit";
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnUpdateUnit.Enabled = false;
            this.btnUpdateUnit.FlatAppearance.BorderSize = 0;
            this.btnUpdateUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUnit.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateUnit.Location = new System.Drawing.Point(97, 126);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(367, 40);
            this.btnUpdateUnit.TabIndex = 5;
            this.btnUpdateUnit.Text = "Update Unit";
            this.btnUpdateUnit.UseVisualStyleBackColor = false;
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
            // 
            // gbAddUnit
            // 
            this.gbAddUnit.Controls.Add(this.tbUnit);
            this.gbAddUnit.Controls.Add(this.label14);
            this.gbAddUnit.Controls.Add(this.btnAddUnit);
            this.gbAddUnit.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.gbAddUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddUnit.Location = new System.Drawing.Point(10, 20);
            this.gbAddUnit.Name = "gbAddUnit";
            this.gbAddUnit.Size = new System.Drawing.Size(560, 239);
            this.gbAddUnit.TabIndex = 21;
            this.gbAddUnit.TabStop = false;
            this.gbAddUnit.Text = "Add Unit";
            this.gbAddUnit.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(164, 66);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(370, 30);
            this.tbUnit.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(64, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "Unit";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAddUnit.FlatAppearance.BorderSize = 0;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddUnit.Location = new System.Drawing.Point(146, 124);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(322, 40);
            this.btnAddUnit.TabIndex = 5;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            this.dgvUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(24, 338);
            this.dgvUnit.MultiSelect = false;
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.RowHeadersVisible = false;
            this.dgvUnit.RowHeadersWidth = 51;
            this.dgvUnit.RowTemplate.Height = 24;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(1162, 507);
            this.dgvUnit.TabIndex = 17;
            this.dgvUnit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label15.Location = new System.Drawing.Point(792, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(394, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Double-Click on a record to update/delete*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comfortaa", 14F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label16.Location = new System.Drawing.Point(17, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 39);
            this.label16.TabIndex = 19;
            this.label16.Text = "Units";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 805);
            this.Controls.Add(this.tcStaff);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tcStaff.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            this.gbUpdateCustomer.ResumeLayout(false);
            this.gbUpdateCustomer.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageSupplier.PerformLayout();
            this.gbUpdateSupplier.ResumeLayout(false);
            this.gbUpdateSupplier.PerformLayout();
            this.gbAddSupplier.ResumeLayout(false);
            this.gbAddSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tpUnit.ResumeLayout(false);
            this.tpUnit.PerformLayout();
            this.gbUpdateUnit.ResumeLayout(false);
            this.gbUpdateUnit.PerformLayout();
            this.gbAddUnit.ResumeLayout(false);
            this.gbAddUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcStaff;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.GroupBox gbUpdateCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.TextBox tbCustomerContact;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TabPage tpUnit;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbUpdateCustomerAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbUpdateCustomeContact;
        private System.Windows.Forms.TextBox tbUpdateCustomerName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbUpdateSupplier;
        private System.Windows.Forms.TextBox tbUpdateSupplierAddress;
        private System.Windows.Forms.Button btnDeleteSupplierInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSupplierInformation;
        private System.Windows.Forms.TextBox tbUpdateSupplierContact;
        private System.Windows.Forms.TextBox tbUpdateSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAddSupplier;
        private System.Windows.Forms.TextBox tbSupplierAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSupplierContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbUpdateUnit;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnUpdateUnit;
        private System.Windows.Forms.GroupBox gbAddUnit;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbUpdateUnit;
        private System.Windows.Forms.Label label9;
    }
}

namespace ZDSPGC_Point_Of_Sale
{
    partial class Credit_Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.gbPayCredit = new System.Windows.Forms.GroupBox();
            this.tbRemaining_Balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCredits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCreditItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCollectibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.gbPayCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Payment History";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(20, 57);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(462, 662);
            this.dgvPayments.TabIndex = 10;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPay.Location = new System.Drawing.Point(161, 153);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(322, 40);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // gbPayCredit
            // 
            this.gbPayCredit.Controls.Add(this.tbRemaining_Balance);
            this.gbPayCredit.Controls.Add(this.label5);
            this.gbPayCredit.Controls.Add(this.tbAmount);
            this.gbPayCredit.Controls.Add(this.label4);
            this.gbPayCredit.Controls.Add(this.btnPay);
            this.gbPayCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbPayCredit.Location = new System.Drawing.Point(528, 501);
            this.gbPayCredit.Name = "gbPayCredit";
            this.gbPayCredit.Size = new System.Drawing.Size(691, 218);
            this.gbPayCredit.TabIndex = 12;
            this.gbPayCredit.TabStop = false;
            this.gbPayCredit.Text = "Pay Credit";
            // 
            // tbRemaining_Balance
            // 
            this.tbRemaining_Balance.Enabled = false;
            this.tbRemaining_Balance.Location = new System.Drawing.Point(267, 101);
            this.tbRemaining_Balance.Name = "tbRemaining_Balance";
            this.tbRemaining_Balance.Size = new System.Drawing.Size(258, 30);
            this.tbRemaining_Balance.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(55, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remaining Balance:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.Enabled = false;
            this.tbAmount.Location = new System.Drawing.Point(267, 58);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(258, 30);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(137, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Payment:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCredits
            // 
            this.dgvCredits.AllowUserToAddRows = false;
            this.dgvCredits.AllowUserToDeleteRows = false;
            this.dgvCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredits.Location = new System.Drawing.Point(528, 57);
            this.dgvCredits.MultiSelect = false;
            this.dgvCredits.Name = "dgvCredits";
            this.dgvCredits.ReadOnly = true;
            this.dgvCredits.RowHeadersVisible = false;
            this.dgvCredits.RowHeadersWidth = 51;
            this.dgvCredits.RowTemplate.Height = 24;
            this.dgvCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCredits.Size = new System.Drawing.Size(691, 205);
            this.dgvCredits.TabIndex = 10;
            this.dgvCredits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredits_CellContentClick);
            this.dgvCredits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredits_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Credits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(1028, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Double Click to pay*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvCreditItems
            // 
            this.dgvCreditItems.AllowUserToAddRows = false;
            this.dgvCreditItems.AllowUserToDeleteRows = false;
            this.dgvCreditItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCreditItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditItems.Location = new System.Drawing.Point(528, 332);
            this.dgvCreditItems.MultiSelect = false;
            this.dgvCreditItems.Name = "dgvCreditItems";
            this.dgvCreditItems.ReadOnly = true;
            this.dgvCreditItems.RowHeadersVisible = false;
            this.dgvCreditItems.RowHeadersWidth = 51;
            this.dgvCreditItems.RowTemplate.Height = 24;
            this.dgvCreditItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditItems.Size = new System.Drawing.Size(691, 137);
            this.dgvCreditItems.TabIndex = 10;
            this.dgvCreditItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredits_CellContentClick);
            this.dgvCreditItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredits_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(520, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "Credit Items";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCollectibles
            // 
            this.lblCollectibles.AutoSize = true;
            this.lblCollectibles.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.lblCollectibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCollectibles.Location = new System.Drawing.Point(975, 265);
            this.lblCollectibles.Name = "lblCollectibles";
            this.lblCollectibles.Size = new System.Drawing.Size(164, 28);
            this.lblCollectibles.TabIndex = 11;
            this.lblCollectibles.Text = "Total Collectibles:";
            this.lblCollectibles.Click += new System.EventHandler(this.label3_Click);
            // 
            // Credit_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1247, 746);
            this.Controls.Add(this.lblCollectibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCreditItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCredits);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.gbPayCredit);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Credit_Payment";
            this.Text = "Credit Payment";
            this.Load += new System.EventHandler(this.Credit_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.gbPayCredit.ResumeLayout(false);
            this.gbPayCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox gbPayCredit;
        private System.Windows.Forms.TextBox tbRemaining_Balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCreditItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCollectibles;
    }
}
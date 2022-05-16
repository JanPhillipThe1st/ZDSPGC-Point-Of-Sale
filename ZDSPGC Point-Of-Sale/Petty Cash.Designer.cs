
namespace ZDSPGC_Point_Of_Sale
{
    partial class Petty_Cash
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPettyCash = new System.Windows.Forms.DataGridView();
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.tbPettyCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyCash)).BeginInit();
            this.gbTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Petty Cash History";
            // 
            // dgvPettyCash
            // 
            this.dgvPettyCash.AllowUserToAddRows = false;
            this.dgvPettyCash.AllowUserToDeleteRows = false;
            this.dgvPettyCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPettyCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPettyCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPettyCash.Location = new System.Drawing.Point(20, 315);
            this.dgvPettyCash.MultiSelect = false;
            this.dgvPettyCash.Name = "dgvPettyCash";
            this.dgvPettyCash.ReadOnly = true;
            this.dgvPettyCash.RowHeadersVisible = false;
            this.dgvPettyCash.RowHeadersWidth = 51;
            this.dgvPettyCash.RowTemplate.Height = 24;
            this.dgvPettyCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPettyCash.Size = new System.Drawing.Size(1201, 403);
            this.dgvPettyCash.TabIndex = 2;
            this.dgvPettyCash.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPettyCash_CellDoubleClick);
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.tbPettyCash);
            this.gbTransaction.Controls.Add(this.label5);
            this.gbTransaction.Controls.Add(this.btnAdd);
            this.gbTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbTransaction.Location = new System.Drawing.Point(20, 24);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(622, 208);
            this.gbTransaction.TabIndex = 8;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Add Petty Cash";
            // 
            // tbPettyCash
            // 
            this.tbPettyCash.Location = new System.Drawing.Point(193, 59);
            this.tbPettyCash.Name = "tbPettyCash";
            this.tbPettyCash.Size = new System.Drawing.Size(370, 30);
            this.tbPettyCash.TabIndex = 4;
            this.tbPettyCash.TextChanged += new System.EventHandler(this.tbPettyCash_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(73, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(145, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(322, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Petty Cash";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Petty_Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1247, 746);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPettyCash);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Petty_Cash";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Petty_Cash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyCash)).EndInit();
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPettyCash;
        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.TextBox tbPettyCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
    }
}
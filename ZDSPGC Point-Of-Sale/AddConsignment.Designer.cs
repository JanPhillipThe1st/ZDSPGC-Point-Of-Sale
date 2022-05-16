
namespace ZDSPGC_Point_Of_Sale
{
    partial class AddConsignment
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
            this.gbConsignment = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbConsignment
            // 
            this.gbConsignment.Location = new System.Drawing.Point(42, 30);
            this.gbConsignment.Name = "gbConsignment";
            this.gbConsignment.Size = new System.Drawing.Size(715, 233);
            this.gbConsignment.TabIndex = 0;
            this.gbConsignment.TabStop = false;
            this.gbConsignment.Text = "Consignment Information";
            // 
            // AddConsignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbConsignment);
            this.Font = new System.Drawing.Font("Comfortaa", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddConsignment";
            this.Text = "AddConsignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsignment;
    }
}
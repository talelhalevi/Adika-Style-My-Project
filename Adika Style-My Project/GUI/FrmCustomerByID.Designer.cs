namespace Adika_Style_My_Project.GUI
{
    partial class FrmCustomerByID
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
            this.btnOpenCust = new System.Windows.Forms.Button();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenCust
            // 
            this.btnOpenCust.Location = new System.Drawing.Point(78, 167);
            this.btnOpenCust.Name = "btnOpenCust";
            this.btnOpenCust.Size = new System.Drawing.Size(101, 23);
            this.btnOpenCust.TabIndex = 0;
            this.btnOpenCust.Text = "פתח פרטי לקוח";
            this.btnOpenCust.UseVisualStyleBackColor = true;
            this.btnOpenCust.Click += new System.EventHandler(this.btnOpenCust_Click);
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(78, 142);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(100, 20);
            this.txtBId.TabIndex = 1;
            this.txtBId.TextChanged += new System.EventHandler(this.txtBId_TextChanged);
            this.txtBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "הקש ת.ז. לקוח";
            // 
            // FrmCustomerByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.btnOpenCust);
            this.Name = "FrmCustomerByID";
            this.Text = "FrmCustomerByID";
            this.Load += new System.EventHandler(this.FrmCustomerByID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCust;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label1;
    }
}
namespace Adika_Style_My_Project.GUI
{
    partial class FrmAddPointsCredit
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBcodeP = new System.Windows.Forms.TextBox();
            this.txtBNumP = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBcodeP
            // 
            this.txtBcodeP.Enabled = false;
            this.txtBcodeP.Location = new System.Drawing.Point(12, 63);
            this.txtBcodeP.Name = "txtBcodeP";
            this.txtBcodeP.Size = new System.Drawing.Size(100, 20);
            this.txtBcodeP.TabIndex = 1;
            this.txtBcodeP.TextChanged += new System.EventHandler(this.txtBcodeP_TextChanged);
            // 
            // txtBNumP
            // 
            this.txtBNumP.Location = new System.Drawing.Point(12, 89);
            this.txtBNumP.Name = "txtBNumP";
            this.txtBNumP.Size = new System.Drawing.Size(100, 20);
            this.txtBNumP.TabIndex = 3;
            this.txtBNumP.TextChanged += new System.EventHandler(this.txtBNumP_TextChanged);
            this.txtBNumP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNumP_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(118, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = ":קוד זיכוי";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(118, 92);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(103, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "הקש מס\' נק\' לזיכוי";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // FrmAddPointsCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 190);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBNumP);
            this.Controls.Add(this.txtBcodeP);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmAddPointsCredit";
            this.Text = "FrmAddPointsCredit";
            this.Load += new System.EventHandler(this.FrmAddPointsCredit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBNumP;
        private System.Windows.Forms.TextBox txtBcodeP;
    }
}
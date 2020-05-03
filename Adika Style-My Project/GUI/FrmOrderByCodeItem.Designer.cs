namespace Adika_Style_My_Project.GUI
{
    partial class FrmOrderByCodeItem
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtCodeOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "הקש קוד הזמנה";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(110, 117);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(69, 53);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "לפרטי הזמנה לחץ כאן";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtCodeOrder
            // 
            this.txtCodeOrder.Location = new System.Drawing.Point(93, 91);
            this.txtCodeOrder.Name = "txtCodeOrder";
            this.txtCodeOrder.Size = new System.Drawing.Size(100, 20);
            this.txtCodeOrder.TabIndex = 2;
            // 
            // FrmOrderByCodeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtCodeOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrderByCodeItem";
            this.Text = "FrmOrderByCodeItem";
            this.Load += new System.EventHandler(this.FrmOrderByCodeItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtCodeOrder;
    }
}
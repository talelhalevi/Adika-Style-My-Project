namespace Adika_Style_My_Project.GUI
{
    partial class ShoppingCartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemColor = new System.Windows.Forms.Label();
            this.lblItemSize = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemName.Location = new System.Drawing.Point(503, 1);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(113, 23);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "חצאית";
            // 
            // lblItemColor
            // 
            this.lblItemColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemColor.Location = new System.Drawing.Point(387, 2);
            this.lblItemColor.Name = "lblItemColor";
            this.lblItemColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemColor.Size = new System.Drawing.Size(113, 22);
            this.lblItemColor.TabIndex = 0;
            this.lblItemColor.Text = "אדום";
            // 
            // lblItemSize
            // 
            this.lblItemSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemSize.Location = new System.Drawing.Point(270, 2);
            this.lblItemSize.Name = "lblItemSize";
            this.lblItemSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemSize.Size = new System.Drawing.Size(113, 22);
            this.lblItemSize.TabIndex = 0;
            this.lblItemSize.Text = "M";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(7, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(67, 21);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "הסר";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemPrice.Location = new System.Drawing.Point(153, 2);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemPrice.Size = new System.Drawing.Size(113, 22);
            this.lblItemPrice.TabIndex = 0;
            this.lblItemPrice.Text = "300";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(168, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ש\"ח";
            // 
            // ShoppingCartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemSize);
            this.Controls.Add(this.lblItemColor);
            this.Controls.Add(this.lblItemName);
            this.Name = "ShoppingCartControl";
            this.Size = new System.Drawing.Size(627, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemColor;
        private System.Windows.Forms.Label lblItemSize;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label1;
    }
}

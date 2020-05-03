namespace Adika_Style_My_Project.GUI
{
    partial class ItemControl
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
            this.pctItemPicture = new System.Windows.Forms.PictureBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.cmbSizes = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblSizes = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblNoStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pctItemPicture
            // 
            this.pctItemPicture.Location = new System.Drawing.Point(13, 7);
            this.pctItemPicture.Name = "pctItemPicture";
            this.pctItemPicture.Size = new System.Drawing.Size(113, 88);
            this.pctItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctItemPicture.TabIndex = 0;
            this.pctItemPicture.TabStop = false;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Location = new System.Drawing.Point(132, 23);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemPrice.Size = new System.Drawing.Size(43, 18);
            this.lblItemPrice.TabIndex = 1;
            this.lblItemPrice.Text = "label1";
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(13, 129);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(113, 21);
            this.cmbColors.TabIndex = 2;
            // 
            // cmbSizes
            // 
            this.cmbSizes.FormattingEnabled = true;
            this.cmbSizes.Location = new System.Drawing.Point(13, 155);
            this.cmbSizes.Name = "cmbSizes";
            this.cmbSizes.Size = new System.Drawing.Size(113, 21);
            this.cmbSizes.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Location = new System.Drawing.Point(106, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(69, 18);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "label1";
            // 
            // lblColors
            // 
            this.lblColors.Location = new System.Drawing.Point(125, 132);
            this.lblColors.Name = "lblColors";
            this.lblColors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColors.Size = new System.Drawing.Size(42, 18);
            this.lblColors.TabIndex = 1;
            this.lblColors.Text = "צבעים";
            // 
            // lblSizes
            // 
            this.lblSizes.Location = new System.Drawing.Point(126, 158);
            this.lblSizes.Name = "lblSizes";
            this.lblSizes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSizes.Size = new System.Drawing.Size(42, 18);
            this.lblSizes.TabIndex = 1;
            this.lblSizes.Text = "מידות";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(13, 99);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(113, 25);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "הוסף לסל";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblNoStock
            // 
            this.lblNoStock.ForeColor = System.Drawing.Color.Red;
            this.lblNoStock.Location = new System.Drawing.Point(41, 182);
            this.lblNoStock.Name = "lblNoStock";
            this.lblNoStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNoStock.Size = new System.Drawing.Size(85, 18);
            this.lblNoStock.TabIndex = 1;
            this.lblNoStock.Text = "אזל המלאי";
            this.lblNoStock.Visible = false;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.cmbSizes);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.lblSizes);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lblNoStock);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.pctItemPicture);
            this.Controls.Add(this.lblItemName);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(180, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pctItemPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctItemPicture;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.ComboBox cmbSizes;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblSizes;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblNoStock;
    }
}

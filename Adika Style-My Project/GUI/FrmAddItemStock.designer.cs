namespace Adika_Style_My_Project.GUI
{
    partial class FrmAddItemStock
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
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.cmbSizes = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lstItemsStock = new System.Windows.Forms.ListView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExplainion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(208, 92);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbItems.Size = new System.Drawing.Size(178, 21);
            this.cmbItems.TabIndex = 7;
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(397, 133);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbColors.Size = new System.Drawing.Size(178, 21);
            this.cmbColors.TabIndex = 8;
            // 
            // cmbSizes
            // 
            this.cmbSizes.FormattingEnabled = true;
            this.cmbSizes.Location = new System.Drawing.Point(208, 133);
            this.cmbSizes.Name = "cmbSizes";
            this.cmbSizes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSizes.Size = new System.Drawing.Size(178, 21);
            this.cmbSizes.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(30, 134);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(175, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // btnAddStock
            // 
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStock.Location = new System.Drawing.Point(30, 160);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(55, 21);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "הוסף";
            this.btnAddStock.UseVisualStyleBackColor = true;
            // 
            // lstItemsStock
            // 
            this.lstItemsStock.AllowDrop = true;
            this.lstItemsStock.Location = new System.Drawing.Point(28, 187);
            this.lstItemsStock.Name = "lstItemsStock";
            this.lstItemsStock.Size = new System.Drawing.Size(546, 151);
            this.lstItemsStock.TabIndex = 12;
            this.lstItemsStock.UseCompatibleStateImageBehavior = false;
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApprove.Location = new System.Drawing.Point(103, 355);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(67, 23);
            this.btnApprove.TabIndex = 13;
            this.btnApprove.Text = "אישור";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(28, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "כמות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "בפרטי צבעים אנא מלא את הצבעים ";
            // 
            // lblExplainion
            // 
            this.lblExplainion.AutoSize = true;
            this.lblExplainion.Location = new System.Drawing.Point(391, 96);
            this.lblExplainion.Name = "lblExplainion";
            this.lblExplainion.Size = new System.Drawing.Size(201, 13);
            this.lblExplainion.TabIndex = 24;
            this.lblExplainion.Text = "שבהם קיים הפריט שהנך מוסיף למאגר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "הפריט";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "המידה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "הצבע";
            // 
            // btnNewColor
            // 
            this.btnNewColor.Location = new System.Drawing.Point(437, 159);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(105, 24);
            this.btnNewColor.TabIndex = 29;
            this.btnNewColor.Text = "להוספת צבע חדש";
            this.btnNewColor.UseVisualStyleBackColor = true;
            this.btnNewColor.Click += new System.EventHandler(this.btnNewColor_Click);
            // 
            // FrmAddItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.btnNewColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExplainion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lstItemsStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbSizes);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.cmbItems);
            this.Name = "FrmAddItemStock";
            this.Text = "FrmAddItemStock";
            this.Load += new System.EventHandler(this.FrmAddItemStock_Load);
            this.Controls.SetChildIndex(this.cmbItems, 0);
            this.Controls.SetChildIndex(this.cmbColors, 0);
            this.Controls.SetChildIndex(this.cmbSizes, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.Controls.SetChildIndex(this.btnAddStock, 0);
            this.Controls.SetChildIndex(this.lstItemsStock, 0);
            this.Controls.SetChildIndex(this.btnApprove, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblExplainion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnNewColor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.ComboBox cmbSizes;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.ListView lstItemsStock;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExplainion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewColor;
    }
}
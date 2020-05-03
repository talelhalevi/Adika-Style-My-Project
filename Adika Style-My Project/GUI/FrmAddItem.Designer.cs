namespace Adika_Style_My_Project.GUI
{
    partial class FrmAddItem
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.txtCodeItem = new System.Windows.Forms.TextBox();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.rdo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPriceItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.lblcoloritem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(77, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(48, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(212, 69);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(24, 13);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "מין";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "שם פריט";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(210, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 13);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = ":קוד פריט";
            // 
            // txtNameItem
            // 
            this.txtNameItem.Location = new System.Drawing.Point(105, 40);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(100, 20);
            this.txtNameItem.TabIndex = 1;
            this.txtNameItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameItem_KeyPress);
            // 
            // txtCodeItem
            // 
            this.txtCodeItem.Enabled = false;
            this.txtCodeItem.Location = new System.Drawing.Point(104, 14);
            this.txtCodeItem.Name = "txtCodeItem";
            this.txtCodeItem.ReadOnly = true;
            this.txtCodeItem.Size = new System.Drawing.Size(100, 20);
            this.txtCodeItem.TabIndex = 0;
            // 
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Location = new System.Drawing.Point(156, 69);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMin.Size = new System.Drawing.Size(43, 17);
            this.rdoMin.TabIndex = 13;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "זכר";
            this.rdoMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMin.UseVisualStyleBackColor = true;
            this.rdoMin.CheckedChanged += new System.EventHandler(this.rdoMin_CheckedChanged);
            // 
            // rdo
            // 
            this.rdo.AutoSize = true;
            this.rdo.Location = new System.Drawing.Point(106, 69);
            this.rdo.Name = "rdo";
            this.rdo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdo.Size = new System.Drawing.Size(51, 17);
            this.rdo.TabIndex = 13;
            this.rdo.TabStop = true;
            this.rdo.Text = "נקבה";
            this.rdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo.UseVisualStyleBackColor = true;
            this.rdo.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "מחיר";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.Location = new System.Drawing.Point(106, 94);
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.Size = new System.Drawing.Size(100, 20);
            this.txtPriceItem.TabIndex = 9;
            this.txtPriceItem.TextChanged += new System.EventHandler(this.txtPriceItem_TextChanged);
            this.txtPriceItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceItem_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "עונה";
            // 
            // cmbSeason
            // 
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Items.AddRange(new object[] {
            "חורף",
            "קיץ",
            "רב עונתי"});
            this.cmbSeason.Location = new System.Drawing.Point(106, 127);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(99, 21);
            this.cmbSeason.TabIndex = 14;
            // 
            // lblcoloritem
            // 
            this.lblcoloritem.AutoSize = true;
            this.lblcoloritem.Location = new System.Drawing.Point(92, 417);
            this.lblcoloritem.Name = "lblcoloritem";
            this.lblcoloritem.Size = new System.Drawing.Size(0, 13);
            this.lblcoloritem.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddPic);
            this.panel1.Controls.Add(this.picItem);
            this.panel1.Controls.Add(this.lblcoloritem);
            this.panel1.Controls.Add(this.cmbSeason);
            this.panel1.Controls.Add(this.rdo);
            this.panel1.Controls.Add(this.rdoMin);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.txtPriceItem);
            this.panel1.Controls.Add(this.txtNameItem);
            this.panel1.Controls.Add(this.txtCodeItem);
            this.panel1.Location = new System.Drawing.Point(117, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 295);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(40, 216);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(55, 48);
            this.btnAddPic.TabIndex = 25;
            this.btnAddPic.Text = "בחר תמונה";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // picItem
            // 
            this.picItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem.Location = new System.Drawing.Point(106, 163);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(130, 102);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 24;
            this.picItem.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmAddItem";
            this.Text = "FrmAddItem";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.TextBox txtCodeItem;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.RadioButton rdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblcoloritem;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
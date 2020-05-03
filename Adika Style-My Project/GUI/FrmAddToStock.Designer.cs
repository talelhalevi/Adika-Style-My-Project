namespace Adika_Style_My_Project.GUI
{
    partial class FrmAddToStock
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblamountOfStock = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmix = new System.Windows.Forms.Label();
            this.btnNewAdd = new System.Windows.Forms.Button();
            this.btnAddToStock = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(180, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(26, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "קוד";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(180, 37);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(28, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "צבע";
            this.lblColor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(180, 59);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "מידה";
            // 
            // lblamountOfStock
            // 
            this.lblamountOfStock.AutoSize = true;
            this.lblamountOfStock.Location = new System.Drawing.Point(180, 83);
            this.lblamountOfStock.Name = "lblamountOfStock";
            this.lblamountOfStock.Size = new System.Drawing.Size(81, 13);
            this.lblamountOfStock.TabIndex = 3;
            this.lblamountOfStock.Text = "כמות עכשווית";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(180, 105);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(96, 13);
            this.lblmax.TabIndex = 4;
            this.lblmax.Text = "כמות מקסימאלית";
            // 
            // lblmix
            // 
            this.lblmix.AutoSize = true;
            this.lblmix.Location = new System.Drawing.Point(180, 128);
            this.lblmix.Name = "lblmix";
            this.lblmix.Size = new System.Drawing.Size(92, 13);
            this.lblmix.TabIndex = 5;
            this.lblmix.Text = "כמות מינימאלית";
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.Location = new System.Drawing.Point(189, 231);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.Size = new System.Drawing.Size(91, 23);
            this.btnNewAdd.TabIndex = 6;
            this.btnNewAdd.Text = "הוספה חדשה";
            this.btnNewAdd.UseVisualStyleBackColor = true;
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.Location = new System.Drawing.Point(73, 231);
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.Size = new System.Drawing.Size(110, 23);
            this.btnAddToStock.TabIndex = 7;
            this.btnAddToStock.Text = "הוסף מלאי למאגר";
            this.btnAddToStock.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "סיים";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(132, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(39, 17);
            this.listBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 102);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FrmAddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddToStock);
            this.Controls.Add(this.btnNewAdd);
            this.Controls.Add(this.lblmix);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblamountOfStock);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCode);
            this.Name = "FrmAddToStock";
            this.Text = "FrmAddToStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblamountOfStock;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblmix;
        private System.Windows.Forms.Button btnNewAdd;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
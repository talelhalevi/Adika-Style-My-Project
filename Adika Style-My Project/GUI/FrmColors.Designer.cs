namespace Adika_Style_My_Project.GUI
{
    partial class FrmColors
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBNameCol = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgv_colors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBNameCol
            // 
            this.txtBNameCol.Location = new System.Drawing.Point(25, 23);
            this.txtBNameCol.Name = "txtBNameCol";
            this.txtBNameCol.Size = new System.Drawing.Size(100, 20);
            this.txtBNameCol.TabIndex = 3;
            this.txtBNameCol.TextChanged += new System.EventHandler(this.txtBNameCol_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(149, 26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(76, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = ":הקש שם צבע";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(45, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgv_colors
            // 
            this.dgv_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colors.Location = new System.Drawing.Point(4, 123);
            this.dgv_colors.Name = "dgv_colors";
            this.dgv_colors.Size = new System.Drawing.Size(235, 217);
            this.dgv_colors.TabIndex = 7;
            // 
            // FrmColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 366);
            this.Controls.Add(this.dgv_colors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBNameCol);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmColors";
            this.Text = "FrmColors";
            this.Load += new System.EventHandler(this.FrmColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBNameCol;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgv_colors;
    }
}
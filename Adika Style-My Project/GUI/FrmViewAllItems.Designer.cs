namespace Adika_Style_My_Project.GUI
{
    partial class FrmViewAllItems
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
            this.dgvViewAllItems = new System.Windows.Forms.DataGridView();
            this.btnDalete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAllItems
            // 
            this.dgvViewAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllItems.Location = new System.Drawing.Point(25, 35);
            this.dgvViewAllItems.Name = "dgvViewAllItems";
            this.dgvViewAllItems.Size = new System.Drawing.Size(240, 195);
            this.dgvViewAllItems.TabIndex = 0;
            this.dgvViewAllItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAllItems_CellContentClick);
            this.dgvViewAllItems.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewAllItems_RowHeaderMouseDoubleClick);
            this.dgvViewAllItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvViewAllItems_MouseClick);
            // 
            // btnDalete
            // 
            this.btnDalete.Location = new System.Drawing.Point(25, 236);
            this.btnDalete.Name = "btnDalete";
            this.btnDalete.Size = new System.Drawing.Size(116, 23);
            this.btnDalete.TabIndex = 1;
            this.btnDalete.Text = "הסר פריט מרשימה";
            this.btnDalete.UseVisualStyleBackColor = true;
            this.btnDalete.Click += new System.EventHandler(this.btnDalete_Click);
            // 
            // FrmViewAllItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnDalete);
            this.Controls.Add(this.dgvViewAllItems);
            this.Name = "FrmViewAllItems";
            this.Text = "FrmViewAllItems";
            this.Load += new System.EventHandler(this.FrmViewAllItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAllItems;
        private System.Windows.Forms.Button btnDalete;
    }
}
namespace Adika_Style_My_Project.GUI
{
    partial class FrmViewColors
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
            this.dgvViewColors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewColors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewColors
            // 
            this.dgvViewColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewColors.Location = new System.Drawing.Point(12, 75);
            this.dgvViewColors.Name = "dgvViewColors";
            this.dgvViewColors.Size = new System.Drawing.Size(240, 150);
            this.dgvViewColors.TabIndex = 0;
            this.dgvViewColors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewColors_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Narkisim", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = ":רשימת צבעים קיימים במערכת";
            // 
            // FrmViewColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewColors);
            this.Name = "FrmViewColors";
            this.Text = "FrmViewColors";
            this.Load += new System.EventHandler(this.FrmViewColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewColors;
        private System.Windows.Forms.Label label1;
    }
}
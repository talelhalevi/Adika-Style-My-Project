namespace Adika_Style_My_Project.GUI
{
    partial class FrmCustomers
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtBFirst = new System.Windows.Forms.TextBox();
            this.txtBLust = new System.Windows.Forms.TextBox();
            this.txtBTel = new System.Windows.Forms.TextBox();
            this.txtBPhon = new System.Windows.Forms.TextBox();
            this.txtBSity = new System.Windows.Forms.TextBox();
            this.txtBHome = new System.Windows.Forms.TextBox();
            this.txtBPost = new System.Windows.Forms.TextBox();
            this.txtBStreet = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(43, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(266, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = ":הקש ת.ז. לקוח";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(266, 77);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = ":הקש שם פרטי ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(266, 103);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(95, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = ":הקש שם משפחה ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(266, 129);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = ":הקש מס\' טלפון ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(266, 156);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(94, 13);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = ":הקש מס\' פלאפון";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(266, 182);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(73, 13);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = ":הקש שם עיר";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(266, 208);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(80, 13);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = ":הקש שם רחוב";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(266, 234);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(67, 13);
            this.lbl8.TabIndex = 9;
            this.lbl8.Text = ":הקש מיקוד";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(266, 260);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(74, 13);
            this.lbl9.TabIndex = 10;
            this.lbl9.Text = ":הקש מס\' בית";
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(151, 48);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(100, 20);
            this.txtBID.TabIndex = 11;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBID_KeyPress);
            // 
            // txtBFirst
            // 
            this.txtBFirst.Location = new System.Drawing.Point(151, 74);
            this.txtBFirst.Name = "txtBFirst";
            this.txtBFirst.Size = new System.Drawing.Size(100, 20);
            this.txtBFirst.TabIndex = 12;
            this.txtBFirst.TextChanged += new System.EventHandler(this.txtBFirst_TextChanged);
            this.txtBFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBFirst_KeyPress);
            // 
            // txtBLust
            // 
            this.txtBLust.Location = new System.Drawing.Point(151, 100);
            this.txtBLust.Name = "txtBLust";
            this.txtBLust.Size = new System.Drawing.Size(100, 20);
            this.txtBLust.TabIndex = 13;
            this.txtBLust.TextChanged += new System.EventHandler(this.txtBLust_TextChanged);
            this.txtBLust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBLust_KeyPress);
            // 
            // txtBTel
            // 
            this.txtBTel.Location = new System.Drawing.Point(151, 126);
            this.txtBTel.Name = "txtBTel";
            this.txtBTel.Size = new System.Drawing.Size(100, 20);
            this.txtBTel.TabIndex = 14;
            this.txtBTel.TextChanged += new System.EventHandler(this.txtBTel_TextChanged);
            this.txtBTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBTel_KeyPress);
            // 
            // txtBPhon
            // 
            this.txtBPhon.Location = new System.Drawing.Point(151, 153);
            this.txtBPhon.Name = "txtBPhon";
            this.txtBPhon.Size = new System.Drawing.Size(100, 20);
            this.txtBPhon.TabIndex = 15;
            this.txtBPhon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPhon_KeyPress);
            // 
            // txtBSity
            // 
            this.txtBSity.Location = new System.Drawing.Point(151, 179);
            this.txtBSity.Name = "txtBSity";
            this.txtBSity.Size = new System.Drawing.Size(100, 20);
            this.txtBSity.TabIndex = 16;
            this.txtBSity.TextChanged += new System.EventHandler(this.txtBSity_TextChanged);
            this.txtBSity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBSity_KeyPress);
            // 
            // txtBHome
            // 
            this.txtBHome.Location = new System.Drawing.Point(151, 257);
            this.txtBHome.Name = "txtBHome";
            this.txtBHome.Size = new System.Drawing.Size(100, 20);
            this.txtBHome.TabIndex = 17;
            this.txtBHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBHome_KeyPress);
            // 
            // txtBPost
            // 
            this.txtBPost.Location = new System.Drawing.Point(151, 231);
            this.txtBPost.Name = "txtBPost";
            this.txtBPost.Size = new System.Drawing.Size(100, 20);
            this.txtBPost.TabIndex = 18;
            this.txtBPost.TextChanged += new System.EventHandler(this.txtBPost_TextChanged);
            this.txtBPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPost_KeyPress);
            // 
            // txtBStreet
            // 
            this.txtBStreet.Location = new System.Drawing.Point(151, 205);
            this.txtBStreet.Name = "txtBStreet";
            this.txtBStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBStreet.TabIndex = 19;
            this.txtBStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBStreet_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 20);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "ביטול";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(92, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 20);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "חזרה";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "עדכן";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBStreet);
            this.Controls.Add(this.txtBPost);
            this.Controls.Add(this.txtBHome);
            this.Controls.Add(this.txtBSity);
            this.Controls.Add(this.txtBPhon);
            this.Controls.Add(this.txtBTel);
            this.Controls.Add(this.txtBLust);
            this.Controls.Add(this.txtBFirst);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.TextBox txtBFirst;
        private System.Windows.Forms.TextBox txtBLust;
        private System.Windows.Forms.TextBox txtBTel;
        private System.Windows.Forms.TextBox txtBPhon;
        private System.Windows.Forms.TextBox txtBSity;
        private System.Windows.Forms.TextBox txtBHome;
        private System.Windows.Forms.TextBox txtBPost;
        private System.Windows.Forms.TextBox txtBStreet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
    }
}
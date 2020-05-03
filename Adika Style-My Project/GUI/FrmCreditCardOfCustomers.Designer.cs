namespace Adika_Style_My_Project.GUI
{
    partial class FrmCreditCardOfCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumCard = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtBThree = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudNumOfPayments = new System.Windows.Forms.NumericUpDown();
            this.dtpValidate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaymentSum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpenPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ": מספר כרטיס אשראי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ": הקש תוקף כרטיס אשראי";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 95);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ":הקש ת.ז. בעל הכרטיס";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 125);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = ":הקש שלוש ספרות בגב הכרטיס";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(376, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = ":סכום קניה לתשלום";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 150);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = ": מספר תשלומים";
            // 
            // txtNumCard
            // 
            this.txtNumCard.Location = new System.Drawing.Point(79, 15);
            this.txtNumCard.Name = "txtNumCard";
            this.txtNumCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumCard.Size = new System.Drawing.Size(141, 20);
            this.txtNumCard.TabIndex = 8;
            this.txtNumCard.TextChanged += new System.EventHandler(this.txtNumCard_TextChanged);
            this.txtNumCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCard_KeyPress);
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(78, 92);
            this.txtBID.Name = "txtBID";
            this.txtBID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBID.Size = new System.Drawing.Size(141, 20);
            this.txtBID.TabIndex = 10;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBID_KeyPress);
            // 
            // txtBThree
            // 
            this.txtBThree.Location = new System.Drawing.Point(78, 122);
            this.txtBThree.Name = "txtBThree";
            this.txtBThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBThree.Size = new System.Drawing.Size(141, 20);
            this.txtBThree.TabIndex = 12;
            this.txtBThree.TextChanged += new System.EventHandler(this.txtBThree_TextChanged);
            this.txtBThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBThree_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAdd.Location = new System.Drawing.Point(16, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ביטול";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Location = new System.Drawing.Point(76, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "אישור";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudNumOfPayments
            // 
            this.nudNumOfPayments.BackColor = System.Drawing.Color.White;
            this.nudNumOfPayments.Location = new System.Drawing.Point(79, 150);
            this.nudNumOfPayments.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumOfPayments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfPayments.Name = "nudNumOfPayments";
            this.nudNumOfPayments.ReadOnly = true;
            this.nudNumOfPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudNumOfPayments.Size = new System.Drawing.Size(142, 20);
            this.nudNumOfPayments.TabIndex = 20;
            this.nudNumOfPayments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpValidate
            // 
            this.dtpValidate.Location = new System.Drawing.Point(79, 68);
            this.dtpValidate.Name = "dtpValidate";
            this.dtpValidate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpValidate.Size = new System.Drawing.Size(142, 20);
            this.dtpValidate.TabIndex = 21;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCustomerName.Location = new System.Drawing.Point(308, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(126, 29);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "טלאל";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(440, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "שלום";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(300, 105);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(179, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "אנא הקש פרטי תשלום:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpValidate);
            this.groupBox1.Controls.Add(this.nudNumOfPayments);
            this.groupBox1.Controls.Add(this.txtBThree);
            this.groupBox1.Controls.Add(this.txtBID);
            this.groupBox1.Controls.Add(this.txtNumCard);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(33, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(442, 212);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "נא לבחור בתאריך את היום הראשון בחודש שלאחר \r\n            התוקף לדוגמא: (01/17) יכ" +
    "תב כ :(01/02/17)";
            // 
            // lblPaymentSum
            // 
            this.lblPaymentSum.BackColor = System.Drawing.Color.White;
            this.lblPaymentSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaymentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPaymentSum.Location = new System.Drawing.Point(308, 54);
            this.lblPaymentSum.Name = "lblPaymentSum";
            this.lblPaymentSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentSum.Size = new System.Drawing.Size(72, 35);
            this.lblPaymentSum.TabIndex = 5;
            this.lblPaymentSum.Text = ":סכום קניה לתשלום";
            this.lblPaymentSum.Click += new System.EventHandler(this.lblPaymentSum_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(138, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 23);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "חזרה לסל קניות";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpenPoint
            // 
            this.btnOpenPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpenPoint.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOpenPoint.Location = new System.Drawing.Point(260, 367);
            this.btnOpenPoint.Name = "btnOpenPoint";
            this.btnOpenPoint.Size = new System.Drawing.Size(99, 23);
            this.btnOpenPoint.TabIndex = 31;
            this.btnOpenPoint.Text = "מימוש זיכוי";
            this.btnOpenPoint.UseVisualStyleBackColor = true;
            this.btnOpenPoint.Visible = false;
            this.btnOpenPoint.Click += new System.EventHandler(this.btnOpenPoint_Click);
            // 
            // FrmCreditCardOfCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 411);
            this.Controls.Add(this.btnOpenPoint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPaymentSum);
            this.Controls.Add(this.label6);
            this.Name = "FrmCreditCardOfCustomers";
            this.Text = "FrmCreditCardOfCustomers";
            this.Load += new System.EventHandler(this.FrmCreditCardOfCustomers_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblPaymentSum, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblCustomerName, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnOpenPoint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumCard;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.TextBox txtBThree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudNumOfPayments;
        private System.Windows.Forms.DateTimePicker dtpValidate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPaymentSum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenPoint;
    }
}
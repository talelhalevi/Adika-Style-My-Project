﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.BLL;

namespace Adika_Style_My_Project.GUI
{
    public partial class FrmPurchase : Form
    {
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void btnAddCos_Click(object sender, EventArgs e)
        {
            FrmCustomers fc = new FrmCustomers(StatusKind.add);
            fc.Show();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            txtCodePur.Text = new OrdersTable().GetNextCode().ToString();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
           
        }
    }
}

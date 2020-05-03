using System;
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
    public partial class FrmAddColors : Form
    {
        public FrmAddColors()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Colors color = new Colors(txtBNameCol.Text);
            DataRow row = color.BuildRow();
            ColorsTable ct = new ColorsTable();
            if (ct.Add(row))
                MessageBox.Show("הצבע התווסף בהצלחה");
            else
                MessageBox.Show("הצבע כבר קיים במאגר");
        }

        private void txtBNameCol_TextChanged(object sender, EventArgs e)
        {
            dgv_colors.DataSource = new ColorsTable().ColorsByColor(txtBNameCol.Text);
        }
    }
}

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
    public partial class FrmColors : Form
    {
        int codeColor;
        public FrmColors()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Colors color = new Colors(txtBNameCol.Text);
            color.CodeColor = new ColorsTable().GetNextCode();
            DataRow row = color.BuildRow();
            ColorsTable ct = new ColorsTable();
            if (ct.Add(row))
            {
                MessageBox.Show("הצבע התווסף בהצלחה");
                this.Close();
            }
            else
                MessageBox.Show("הצבע כבר קיים במאגר");
        }

        private void txtBNameCol_TextChanged(object sender, EventArgs e)
        {
            dgv_colors.DataSource = new ColorsTable().ColorsByColor(txtBNameCol.Text);
        }

        private void dgv_colors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmColors_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

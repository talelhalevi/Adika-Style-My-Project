using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.GUI;
using Adika_Style_My_Project.BLL;

namespace Adika_Style_My_Project.GUI
{
    public partial class FrmViewColors : Form
    {

          DataTable dt;
          public FrmViewColors()
        {
            InitializeComponent();
            ColorsTable ct = new ColorsTable();
            dt = ct.GetTable();
          }
        private void dgvViewColors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmViewColors_Load(object sender, EventArgs e)
        {
            dgvViewColors.DataSource = dt;
        }

    }
}

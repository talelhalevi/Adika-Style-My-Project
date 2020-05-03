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
    public partial class FrmViewItems : Form
    {
        Form frmPic;
        Items item;
        ItemsTable items;
        public FrmViewItems()
        {
            InitializeComponent();
            items = new ItemsTable();
        }

        private void FrmViewItems_Load(object sender, EventArgs e)
        {
            dgItems.DataSource = items.GetItemsBySeason();
        }

        private void dgItems_DragDrop(object sender, DragEventArgs e)
        {
           MessageBox.Show("hfgh");
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgItems_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void dgItems_MouseDown(object sender, MouseEventArgs e)
        {
            int o = Convert.ToInt32(dgItems.CurrentRow.Cells[0].Value);

           frmPic= new frmPicItem(o);
            frmPic.Show();
        }

        private void dgItems_MouseUp(object sender, MouseEventArgs e)
        {
            frmPic.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

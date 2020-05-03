using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.BLL;
using Adika_Style_My_Project.DAL;

namespace Adika_Style_My_Project.GUI
{
    public partial class FrmViewAllItems : Form
    {
        int iRow;
          DataTable dt;
          public FrmViewAllItems()
        {
            InitializeComponent();
            ItemsTable a = new ItemsTable();
            dt = a.GetTable();
        }

     
         
    
        private void dgvViewAllItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void FrmViewAllItems_Load(object sender, EventArgs e)
        {
            dgvViewAllItems.DataSource = dt;
        }

        private void dgvViewAllItems_MouseClick(object sender, MouseEventArgs e)
        {
            btnDalete.Visible = true;
        }

        private void btnDalete_Click(object sender, EventArgs e)
        {
            Items item=new Items(dgvViewAllItems.Rows[iRow].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הפריט " + " ?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)//אם המשתמש מקיש כן
            {
                ItemsTable i = new ItemsTable();//שם הבלה בטיבל
                DataRow row = item.BuildRow();//שורה מהטבלה על הצם במקרה שלך זה  הקניה
                if(i.Delete(row));
                MessageBox.Show("הפריט נמחק בהצלחה");
                this.Close();
            }
        }

        private void dgvViewAllItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            iRow = e.RowIndex;
        }
      
    }
}

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
    public partial class FrmAddItem : FrmBasic
    {
        private Items ite;
        Items item;
        ItemsTable items;
        private StatusKind statusKind;
        public string FilePath { get; set; }
        public FrmAddItem()
        {
            InitializeComponent();
            FilePath = "";
        }

        public FrmAddItem(StatusKind statusKind)
        {
            // TODO: Complete member initialization
            this.statusKind = statusKind;
        }

        private void FrmItems_Load(object sender, EventArgs e)
        {

            if (statusFrm == StatusKind.update)
            {
                btnUpdate.Visible = true;
            }

            if (statusFrm == StatusKind.add)
            {
                btnAdd.Visible = true;
            }
            if (statusFrm == StatusKind.show)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                //  אני צריכה להוסיף כאן שהגט נקסט קוד שאמור לקבל הפריט כקוד בהוספה יראו אותו כאן בטקסט בוקס של הקוד


                //    if (statusFrm == StatusKind.add) btnAdd.Visible = true;
                //    if (statusFrm == StatusKind.update)
                //    {
                //        btnUpdate.Visible = true;
                //    }

            }
          //  cmbColors.DataSource = new ColorsTable().GetTable();

          //  cmbColors.DisplayMember = "Expr1";
          //  cmbColors.ValueMember = "NameColor";

           
          //cmbColors.Text = "--בחר צבע--";
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            item = BuildObjedtByField();
            if (item != null)
            {
                DataRow dr = item.BuildRow();
                items = new ItemsTable();
                if (items.Add(dr) == false)
                    MessageBox.Show("קיים במאגר");
                else
                    MessageBox.Show("התווסף בהצלחה");
                this.Close();

            }
        }

        public Items BuildObjedtByField()
        {
            ItemsTable itemT = new ItemsTable();
           // item.CodeItem1 = new ItemsTable().getNextCode().ToString();
            errorProvider1.Clear();
            item = new Items();
            bool ok = true;
            try
            {

                item.CodeItem1 = itemT.getNextCode() + "";
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCodeItem, ex.Message);
                ok = false;


            }
            if (cmbSeason.Text=="חורף")
                item.SeasonItem1 = "winter";
            if (cmbSeason.Text == "קיץ")
                item.SeasonItem1 = "summer";
            if (cmbSeason.Text == "רב עונתי")
                item.SeasonItem1 = "allSeason";


            item.Status1 = true;
           
            try
            {
                item.NameItem1 = txtNameItem.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNameItem, ex.Message);
                ok = false;

            }
            try
            {
                if(rdoMin.Checked==true)
                item.MinItem1 =rdoMin .Text;
                if (rdoMin.Checked == true)
                    item.MinItem1 = rdo.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lbl3, ex.Message);
                ok = false;

            }
            try
            {
                item.PriceItem1 = txtPriceItem.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPriceItem, ex.Message);
                ok = false;

            }
           
            //add picture
            if (FilePath != "" && System.IO.File.Exists(FilePath))
            {
                item.PictureItemDescription1 = getPicName(FilePath)+"."+getFileExtension(FilePath);
                string newPath = System.IO.Directory.GetCurrentDirectory() + @"\pictures\" + item.PictureItemDescription1;
                try
                {
                    System.IO.File.Copy(FilePath, newPath);
                }
                catch (Exception)
                {
                    
                  
                }
                
            }


            if (ok)
                return item;
            return null;
        }

        private string getFileExtension(string filePath)
        {
            string[] args = filePath.Split(new char[] { '.' });
            int count = args.Length;
            string extension = args[count - 1];
            return extension;
        }

        private string getPicName(string filePath)
        {
            string[] args = filePath.Split(new char[] { '.','\\' });
            int count = args.Length;
            string name = args[count - 2];
            return name;
        }

        

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            //הקוד של הפריט(הגט נקסט) מועתק לקוד פריט בטופס שנפתח של המלאי ואז פשוט לעשות הוספה עי מילוי פרטים
            FrmAddToStock f = new FrmAddToStock(item.CodeItem1);
            f.Show();
        }

        private void btnAddColorToList_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FilePath = openFileDialog1.FileName;
            if (System.IO.File.Exists(FilePath))
            {
                if (isPicture(FilePath)==false)
                {
                    MessageBox.Show("פורמט תמונה לא נתמך");
                    FilePath = "";
                }
                else
                {
                    picItem.ImageLocation = FilePath;
                }

            }
            else
            {
                FilePath = "";
            }
        }
        public bool isPicture(string filePath)
        {
            string[] args = filePath.Split(new char[] { '.' });
            int count = args.Length;
            string extension = args[count - 1];
            if (extension.Equals("PNG") || extension.Equals("png") || extension.Equals("jpg") || extension.Equals("JPEG") || extension.Equals("gif") || extension.Equals("GIF") || extension.Equals("JPG"))
                return true;
            return false;
        }

        private void txtNameItem_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public StatusKind statusFrm { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ite = BuildObjedtByField();
            if (ite != null)
            {
                DataRow dr = ite.BuildRow();
                ItemsTable prodacts = new ItemsTable();
                if (prodacts.Update(dr) == false)
                    MessageBox.Show("קיים במאגר");
                else
                {
                    MessageBox.Show("עודכן בהצלחה");
                  
                }
            }
        }

        private void txtPriceItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPriceItem.Text.Length > 4 && e.KeyChar != 8) e.Handled = true;
        }
    }
}

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
   
    public partial class FrmAddItemStock : FrmBasic
    {
        public List<SingleitemStock> ItemsStockList { get; set; }
        public int NextCode { get; set; }
        public FrmAddItemStock()
        {
            ColorsTable colorsT=new ColorsTable();
            SizesTable sizesT = new SizesTable();
            ItemsTable itemsT = new ItemsTable();
            ItemStockTable itemStockT = new ItemStockTable();
            ItemsStockList=new List<SingleitemStock>();
            NextCode = itemStockT.getNextCode();
            InitializeComponent();
            //colors cmb
            cmbColors.DataSource = colorsT.Dt;
            cmbColors.DisplayMember = "NameColor";
            cmbColors.ValueMember = "CodeColor";
            cmbColors.SelectedValue = -1;
            cmbColors.Text = "-בחר צבע-";
            //sizes cmb
            cmbSizes.DataSource = sizesT.Dt;
            cmbSizes.DisplayMember = "nameSize";
            cmbSizes.ValueMember = "codeSize";
            cmbSizes.SelectedValue = -1;
            cmbSizes.Text = "-בחר מידה-";
            //items cmb
            cmbItems.DataSource = itemsT.Dt;
            cmbItems.DisplayMember = "NameItem";
            cmbItems.ValueMember = "CodeItem";
            cmbItems.SelectedValue = -1;
            cmbItems.Text = "-בחר פריט-";
            //disable cmb and txtAmount before choosing an item
            cmbSizes.Enabled = false;
            cmbColors.Enabled = false;
            txtAmount.Enabled = false;
            btnAddStock.Enabled = false;
            //add events to cmb and txt
            cmbColors.KeyPress+=new KeyPressEventHandler(cmbColors_KeyPress);
            cmbSizes.KeyPress += new KeyPressEventHandler(cmbColors_KeyPress);
            cmbItems.KeyPress += new KeyPressEventHandler(cmbColors_KeyPress);
            txtAmount.KeyPress+=new KeyPressEventHandler(txtAmount_KeyPress);
            cmbItems.SelectedValueChanged += new EventHandler(cmbItems_SelectedValueChanged);
            cmbColors.SelectedValueChanged += new EventHandler(cmbSizes_SelectedValueChanged);
            cmbSizes.SelectedValueChanged += new EventHandler(cmbSizes_SelectedValueChanged);
            txtAmount.TextChanged += new EventHandler(cmbSizes_SelectedValueChanged);
             btnAddStock.Click+=new EventHandler(btnAddStock_Click);
            btnApprove.Click+=new EventHandler(btnApprove_Click);
            //initialize itemStocks list
            int columnWidth=lstItemsStock.Width/4;
            lstItemsStock.View = View.Details;
            lstItemsStock.GridLines = true;
            lstItemsStock.FullRowSelect = true;
            lstItemsStock.RightToLeft = RightToLeft.Yes;
            lstItemsStock.Columns.Add("כמות", columnWidth);
            lstItemsStock.Columns.Add("מידה", columnWidth);
            lstItemsStock.Columns.Add("צבע", columnWidth);
            lstItemsStock.Columns.Add("שם פריט", columnWidth);
        }
        void cmbSizes_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((cmbSizes.SelectedValue!=null &&!cmbSizes.SelectedValue.Equals(-1)) && (cmbColors.SelectedValue!=null&&!cmbColors.SelectedValue.Equals(-1) )&& txtAmount.Text != "")
                btnAddStock.Enabled = true;
            else
                btnAddStock.Enabled = false;
        }

      
        void cmbItems_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cmbItems.SelectedValue.Equals(-1))
            {
                cmbSizes.Enabled = true;
                cmbColors.Enabled = true;
                txtAmount.Enabled = true;
            }
        }

        private void cmbColors_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                //add item to list
                SingleitemStock currentStock = new SingleitemStock();
                currentStock.CodeItem = int.Parse(cmbItems.SelectedValue.ToString());
                currentStock.CodeColor = int.Parse(cmbColors.SelectedValue.ToString());
                currentStock.CodeSize = int.Parse(cmbSizes.SelectedValue.ToString());
                currentStock.Amount = int.Parse(txtAmount.Text);
                currentStock.CodeItemStock = NextCode;
                NextCode++;
                ItemsStockList.Add(currentStock);
                //add item to list view
                lstItemsStock.Items.Add(new ListViewItem(new string[] { txtAmount.Text, cmbSizes.Text, cmbColors.Text, cmbItems.Text }));
                //empty controls
                cmbColors.SelectedValue = -1;
                cmbColors.SelectedText = "-בחר צבע-";
                //sizes cmb
                cmbSizes.SelectedValue = -1;
                cmbSizes.Text = "-בחר מידה-";
                //items cmb
                txtAmount.Text = "";
                btnAddStock.Enabled = false;
            }
            catch (Exception)
            {

            }
           
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                ItemStockTable itemsStockT = new ItemStockTable();
                DataRow rowToAdd;
                if (ItemsStockList.Count != 0)
                {
                    foreach (var item in ItemsStockList)
                    {
                        rowToAdd = itemsStockT.Dt.NewRow();
                        rowToAdd["codeItemInStoke"] = item.CodeItemStock;
                        rowToAdd["CodeItem"] = item.CodeItem;
                        rowToAdd["colorOfItem"] = item.CodeColor;
                        rowToAdd["codeSize"] = item.CodeSize;
                        rowToAdd["amountOfStoke"] = item.Amount;
                        rowToAdd["minStoke"] = 0;
                        rowToAdd["maxStoke"] = 100;
                        itemsStockT.Add(rowToAdd);
                    }
                    MessageBox.Show("הפריטים הוספו למלאי בהצלחה");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("אין מלאי להוספה");
                }
            }
            catch (Exception)
            {
                
               
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcolors_Click(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmAddItemStock_Load(object sender, EventArgs e)
        {

        }

        private void btnNewColor_Click(object sender, EventArgs e)
        {
            FrmColors f = new FrmColors();
            f.Show();
        }

       
    }
    public class SingleitemStock
    {
        public int CodeItemStock { get; set; }
        public int CodeItem { get; set; }
        public int CodeColor { get; set; }
        public int CodeSize { get; set; }
        public int Amount { get; set; }
    }
}

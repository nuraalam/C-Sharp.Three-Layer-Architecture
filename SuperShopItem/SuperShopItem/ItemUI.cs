using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopItem.BLL;
using SuperShopItem.DLL.DAO;

namespace SuperShopItem
{
    public partial class ItemUI : Form
    {
        private Item anItem;

        public ItemUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                anItem = new Item(idTextBox.Text, Convert.ToInt32(quantityTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the  value accordingly");
                return;
            }
           
            ItemBLL anItemBLL=new ItemBLL();
            string msg = anItemBLL.Save(anItem);
            MessageBox.Show(msg);
        }
    }
}

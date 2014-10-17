using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShop.BLL;
using SuperShop.DLL.DAO;

namespace SuperShop
{
    public partial class ShopUI : Form
    {
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Shop aShop=new Shop(nameTextBox.Text,addressTextBox.Text);
            ShopBLL aShopBLL=new ShopBLL();
            string msg=aShopBLL.Save(aShop);
            MessageBox.Show(msg);
        }
    }
}

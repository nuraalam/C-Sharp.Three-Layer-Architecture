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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            ShowShopDataGridView();
        }

        private void ShowShopDataGridView()
        {
            ShopBLL aShopBLL=new ShopBLL();
            shopDataGridView.DataSource=aShopBLL.ShopList();
            shopDataGridView.Columns[0].HeaderText = "Shop Code No.";
            
            
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            ShopUI aShopUi=new ShopUI();
            aShopUi.ShowDialog();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            ItemUI aItemUi=new ItemUI();
            aItemUi.ShowDialog();
        }
    }
}

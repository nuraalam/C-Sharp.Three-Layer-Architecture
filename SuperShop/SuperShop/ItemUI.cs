using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SuperShop.BLL;
using SuperShop.DLL.DAO;
using SuperShop.DLL.DAO.View;
using SuperShop.DLL.Gateway;

namespace SuperShop
{
    public partial class ItemUI : Form
    {
        private Item anItem;
        private ItemBLL anItemBLL;
        private ShopBLL aShopBLL;

        public ItemUI()
        {
            InitializeComponent();
            ShowShopComboBox();
        }

        private void ShowShopComboBox()
        {
            aShopBLL = new ShopBLL();

            List<Shop> shopList = aShopBLL.ShopList();
            foreach (Shop shop in shopList)
            {
                shopComboBox.Items.Add(shop);
            }
            shopComboBox.DisplayMember = "aShop";
            shopComboBox.ValueMember = "ShopID";
            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                anItem = new Item(idTextBox.Text, Convert.ToInt32(quantityTextBox.Text));
                Shop aShop = (Shop)shopComboBox.SelectedItem;
                anItem.ShopID = aShop.ShopID;
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the  value accordingly");
                return;
            }
            
            anItemBLL = new ItemBLL();
            string msg = anItemBLL.Save(anItem);
           
            ShopItemListView();

            MessageBox.Show(msg);
        }

        private void ShopItemListView()
        {
            shopItemListView.Items.Clear();
            List<ShopItem> aShopItems=anItemBLL.GetItemList(anItem);
            foreach (ShopItem aShopItem in aShopItems)
            {
                ListViewItem item = new ListViewItem(aShopItem.ItemName);
                item.SubItems.Add(aShopItem.Quantity.ToString());
                shopItemListView.Items.Add(item); 
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using SuperShop.DLL.DAO;
using SuperShop.DLL.DAO.View;
using SuperShop.DLL.Gateway;

namespace SuperShop.BLL
{
    class ItemBLL
    {
        private ItemGatway anItemGatway;

        public string Save(Item anItem)
        {
            if (CheckAnIdIsEmty(anItem.Id))
                return "please fill the Id field";
            if (CheckAnIdwithShopNameIsExist(anItem))
            {
                anItemGatway.UpgreadeQuantity(anItem);
                return "Quantity is upgraded";
            }
            anItemGatway.Save(anItem);
            return "Data is saved";
        }

        private bool CheckAnIdwithShopNameIsExist(Item anItem)
        {

            anItemGatway = new ItemGatway();
            List<ShopItem> itemIdList = anItemGatway.GetShopItemList();
            foreach (ShopItem item in itemIdList)
            {
                if ((anItem.Id==item.ItemName)&&(anItem.ShopID==item.ShopID))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckAnIdIsEmty(string id)
        {
            if (id == String.Empty)
                return true;
            return false;
        }

        public List<ShopItem> GetItemList(Item anItem)
        {
            List<ShopItem> itemAndQuantity=anItemGatway.GetShopItemList();
            List<ShopItem> returnItems = new List<ShopItem>();

            foreach (ShopItem shopItem in itemAndQuantity)
            {
                if (anItem.ShopID==shopItem.ShopID)
                {
                    returnItems.Add(shopItem);
                }
            } 
            return returnItems;  
        }
    }
}

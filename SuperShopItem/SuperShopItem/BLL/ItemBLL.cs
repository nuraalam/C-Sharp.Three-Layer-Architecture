using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopItem.DLL.DAO;
using SuperShopItem.DLL.Gateway;

namespace SuperShopItem.BLL
{
    class ItemBLL
    {
        private ItemGatway anItemGatway;

        public string Save(Item anItem)
        {
            if (CheckAnIdIsEmty(anItem.Id))
                return "please fill the Id field";
            if (CheckAnIdISExist(anItem.Id))
            {
                anItemGatway.UpgreadeQuantity(anItem);
                return "Quantity is upgraded";
            }
            anItemGatway.Save(anItem);
            return "Data is saved";
        }

        private bool CheckAnIdISExist(string id)
        {
            anItemGatway = new ItemGatway();
            List<string> itemIdList = anItemGatway .GetIdList();
            foreach (string item in itemIdList)
            {
                if (id==item)
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
    }
}

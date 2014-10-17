using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShop.DLL.DAO;
using SuperShop.DLL.Gateway;

namespace SuperShop.BLL
{
    class ShopBLL
    {
        private ShopGateway aShopGateway;

        public string Save(Shop aShop)
        {
            if (CheakAshopIsNull(aShop))
                return "please fill the fields";
            if (CheckShopIsValid(aShop))
            {
                return "Shop Name is alrady exist";
            }
            aShopGateway.Save(aShop);
            return "Data is saved";
        }

        private bool CheckShopIsValid(Shop aShop)
        {

            var shopList = ShopList();

            foreach (Shop shop in shopList)
            {
                if (shop.Name==aShop.Name&&shop.Address==aShop.Address)
                {
                    return true;
                }
            }
            return false;

        }

        public List<Shop> ShopList()
        {
            aShopGateway=new ShopGateway();
            List<Shop> shopList = aShopGateway.GetShopList();
            return shopList;
        }


        private bool CheakAshopIsNull(Shop aShop)
        {
            if ((aShop.Name == string.Empty) || (aShop.Address == string.Empty))
                return true;
            return false;
        }
    }
}

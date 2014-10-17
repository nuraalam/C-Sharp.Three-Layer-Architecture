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
            if (CheakShopNameIsExist(aShop.Name))
            {
                return "Shop Name is alrady exist";
            }
            aShopGateway.Save(aShop);
            return "Data is saved";
        }

        private bool CheakShopNameIsExist(string name)
        {
            aShopGateway = new ShopGateway();
            List<string>shopNameList=aShopGateway.GetShopNameList();
            foreach (string shopName in shopNameList)
            {
                if (shopName==name)
                {
                    return true;
                }
            }
            return false;

        }

        private bool CheakAshopIsNull(Shop aShop)
        {
            if ((aShop.Name == string.Empty) || (aShop.Address == string.Empty))
                return true;
            return false;
        }
    }
}

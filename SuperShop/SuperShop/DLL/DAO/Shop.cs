using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.DLL.DAO
{
    class Shop
    {
        public int ShopID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string aShop
        {
            get
            {
                return Name + "(" + Address+")";
            }
        }


        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {
        }
    }
}

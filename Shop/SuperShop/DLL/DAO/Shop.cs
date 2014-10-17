using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.DLL.DAO
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}

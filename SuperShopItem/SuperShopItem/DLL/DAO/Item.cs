using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopItem.DLL.DAO
{
    class Item
    {
        public string Id { get; set; }
        public int Quantity { get; set; }

        public Item(string id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }
    }
}

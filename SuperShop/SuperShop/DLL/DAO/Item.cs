namespace SuperShop.DLL.DAO
{
    class Item
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public int ShopID { get; set; }

        public Item(string id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }
    }
}

using Supermarket.Item;

public class Buyer
    {

        internal int id { get; }
    
        internal Basket basket;

        public Buyer(int _id)
        {
            this.id = _id;
        }
        
        internal Basket PutCart()
        {
            return basket;
        }
        internal void AddItemIntoCart(Item item)
        {
            if (basket == null)
            {
                basket = new Basket();
            }
            basket.addItem(item);
        }
}
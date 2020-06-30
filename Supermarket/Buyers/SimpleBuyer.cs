using Supermarket.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SimpleBuyer
{
        private int id;
        private Basket basket;

        public void addItemIntoCart(Item item)
        {
            if(basket==null)
            {
                basket = new Basket();
            }
            basket.addItem(item);
        }

        public Basket putCart()
        {
            return basket;
        }

        public SimpleBuyer(int _id)
        {
            this.id = _id;
        }
}


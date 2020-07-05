using Supermarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Item;
namespace Supermarket.Item
{

    enum cashBoxState 
    {
        WORK = 1 ,
        NOT_WORK = 2
    }

    class CashBox : ICustomerWorkable
    {

        private static CashBox instance;


        Queue<Buyer> buyer_queue = new Queue<Buyer>();
        cashBoxState current_state;
        private CashBox()
        {

        }
        public static CashBox getInstance()
        {
            if (instance == null)
                instance = new CashBox();
            return instance;
        }
        private List<Item> items_in_cart;
        private int num_cash;
        private StringBuilder informator = new StringBuilder();
        
        CashBox(int _num_cash)
        {
            this.num_cash = _num_cash;
        }

        public void setState(cashBoxState state)
        {
            current_state = state;
        }

        public cashBoxState getState()
        {
            return current_state;
        }

        private static int CalculateCash(List<Item> items_in_basket)
        {
            
            var items = from item in items_in_basket select item;
            foreach (Item i in items) 
                Console.WriteLine(i.name + "|" + i.price);
            int sum = items_in_basket.Sum(n=>n.price);
            return sum;
        }

        public void addCustomerToQueue(Buyer buyer_current)
        {
            buyer_queue.Enqueue(buyer_current);        
        }

      
        public void processCustomer()
        {

            for(int i=0; i<buyer_queue.Count; i++)
            {
                Buyer person = buyer_queue.Dequeue();
                Basket persons_basket = person.PutCart();
                items_in_cart = persons_basket.getItems();
                
               
                informator.Append("У покупателя номер ");
                informator.Append(person.id);
                informator.Append(" Сумма = ");
                informator.Append(CalculateCash(items_in_cart));
                Console.WriteLine("_________________________");
                Console.WriteLine(informator);     
            }
            
        }

    }
}

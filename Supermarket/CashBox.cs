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
        public void addCustomerToQueue(Buyer buyer_current)
        {

           

        }

      
        public List<string> processCustomer()
        {

            List<string> items_sold = new List<string>();
            return items_sold;
        }

    }
}

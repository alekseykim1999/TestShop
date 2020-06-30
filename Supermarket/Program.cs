using Supermarket.Buyers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Mike first_item = new Mike("Coloss", 500, 43, "Cotton", "TTX", 3);
            Milk second_item = new Milk("Health", 200, new DateTime(2015, 7, 20), 20, 30);
            first_item.getInformation();
            second_item.getInformation();

            SmartBuyer buyer_one = new SmartBuyer(1);
            buyer_one.addItemIntoCart(first_item);
            buyer_one.addItemIntoCart(second_item);
            Console.ReadLine();


            
        }
    }
}

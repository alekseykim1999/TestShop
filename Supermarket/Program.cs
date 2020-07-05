using Supermarket.Buyers;
using Supermarket.Item;
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
            Jeans third_item = new Jeans("K_jeans", 3000, 40, "cotton", "Santa Maria", true);
            Cleaner fourth_item = new Cleaner("Superclean",300,4.5,"plate");
            Sausage fifth_item = new SausageBuilder().setCompany("MeatGodman").setName("MeatHealth").setPrice(200);

           

            SimpleBuyer buyer_one = new SimpleBuyer(1);
            buyer_one.AddItemIntoCart(first_item);
            buyer_one.AddItemIntoCart(second_item);
            buyer_one.AddItemIntoCart(third_item);
            buyer_one.AddItemIntoCart(fourth_item);

            CashBox cash_box = CashBox.getInstance();

            cash_box.setState(cashBoxState.WORK);
            cash_box.addCustomerToQueue(buyer_one);
            cash_box.processCustomer();

            Console.ReadLine();           
        }
    }
}

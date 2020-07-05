using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Interfaces
{
    interface ICustomerWorkable
    {
        void addCustomerToQueue(Buyer buyer_current);

        void processCustomer();

    }
}

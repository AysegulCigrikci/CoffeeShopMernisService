using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        //İkisindede aynı save işlemi oldugundan abstract class yaptık.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :" + customer.FirstName);
        }
    }
}

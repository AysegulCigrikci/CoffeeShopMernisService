using CoffeeShop.Abstract;
using CoffeeShop.Adepters;
using CoffeeShop.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {
        //Note: Starbucks ve Neroya kayıt olurken Mernis sorgulama ile gerçek operasyon işlemi
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(1992, 2, 15),
                FirstName = "Ayşegül",
                LastName = "Çığrıkçı",
                NationalityId = "155"
            });
            Console.ReadLine();
        }
    }

    
}

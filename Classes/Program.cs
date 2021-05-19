using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yasin";
            customer.LastName = "ÖZBEK";
            customer.City = "Van";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "istanbul",
                FirstName = "Engin",
                LastName = "Demiroğ"
            };
            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }

}

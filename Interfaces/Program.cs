using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();//ctrl + r , ctrl + m;
            //interface soyuttut newlenemez
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
                {
                    new SqlServerCustomerDal(),
                    new OracleServerCustomerDal()
                };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yasin",
                lastName = "ÖZBEK",
                Address = "Van"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Engin",
                lastName = "Demirog",
                Departmant = "Computer Sciences"
            };

            manager.Add(customer);
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string lastName { get; set; }
    }

    class Customer : IPerson
    {//IPersone implemente ediliyorsa tanımlanan değişkenlerin değerleri yazılmalıdır
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) //customer yazarsak studenti yazdıramaz ıperson ikisinde de zorunlu olduğu için yazdırır
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

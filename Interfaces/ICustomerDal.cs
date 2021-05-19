using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal//dataaccesLayerden geliyor veri tabanı işlemleri
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Sql Güncellendi");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Güncellendi");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}

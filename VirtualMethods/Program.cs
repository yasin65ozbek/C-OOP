using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{//inheritenceda kullanılır
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add() //Virtual kullanma sebebimiz hepsinde aynı yapıyı kullanıcaksak gerek yok ama farklı tanımlamalar olacksa virtual yazılmalıdır OVVERİDE ile ezilmelidir kullanıldığı yerde
        {
            Console.WriteLine("Eklendi");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Silindi!");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("SQL Kodu ile Eklendi");
            //base.Add();
        }
    }

    class MySql:Database
    {

    }
}

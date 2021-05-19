using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; } //prop + TAB + TAB
        private string _firstName;
        public string FirstName 
        { 
            get { return "Sayın " + _firstName; } //Encapsulation
            set { _firstName = value; } 
        }
        public string LastName { get; set; }
        public string City { get; set; } //bu bir property tanımı
        //public String Cityy; // bu bir field tanımı 
    }
}

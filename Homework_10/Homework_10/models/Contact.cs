using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Contact
    {
        public char FirstLet { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }

        public Contact(string Name, string Surname, int Number)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Number = Number;
        }

        public Contact(char FirstLet)
        {
            this.FirstLet = FirstLet;   
        }

        public Contact()
        {
        }

        public void write()
        {
            Console.WriteLine($"Name: {this.Name}, Surname: {this.Surname}, Phone number: {this.Number}\n");
        }        
    }
}

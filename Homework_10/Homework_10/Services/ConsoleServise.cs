using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class ConsoleServise
    {
        public bool Do(bool flag, ContactLibrary contactLibrary)
        {
            Adder adder = new Adder();
            string name;
            string surname;
            int number;
            Console.WriteLine("Contacts");
            Console.WriteLine("What is do first?:\n1) Show english contacts\n2) Show russian contacts\n3) Show 0-9 contacts\n4) Add new contact\n5) Delete a contact\n6) Close the program");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    contactLibrary.Show(0);
                    contactLibrary.Show(1);
                    contactLibrary.Show(2);
                    contactLibrary.Show(3);
                    break;
                case "2":
                    contactLibrary.Show(1);
                    contactLibrary.Show(0);
                    contactLibrary.Show(2);
                    contactLibrary.Show(3);
                    break;
                case "3":
                    contactLibrary.Show(2);
                    contactLibrary.Show(0);
                    contactLibrary.Show(1);
                    contactLibrary.Show(3);
                    break;
                case "4":
                    Console.WriteLine("Enter the name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("Enter the number");
                    number = Convert.ToInt32(Console.ReadLine());
                    Sorter sorter = new Sorter();
                    sorter.Sort(contactLibrary, new Contact(name, surname, number));
                    Console.WriteLine("Adding successfully");
                    break;
                case "5":
                    Console.WriteLine("Enter the name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("Enter the number");
                    number = Convert.ToInt32(Console.ReadLine());
                    adder.DelContact(contactLibrary, new Contact() { Name = name, Surname = surname, Number = number });
                    break;
                case "6":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Make a choice from the options\n");
                    break;
            }
            return flag;
        }
    }
}

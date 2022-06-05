using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Adder
    {  
        public void DelContact(ContactLibrary contactLibrary, Contact contact)
        {
            bool check = true;
            int f = (int)contact.Surname[0];
            if ((f >= 65) && (f <= 90))
            {
                for (int i = 1; i < contactLibrary.contactLibrarys[0].Lib[f - 65].Count; i++)
                {
                    if ((contactLibrary.contactLibrarys[0].Lib[f - 65][i].Name == contact.Name) && 
                        (contactLibrary.contactLibrarys[0].Lib[f - 65][i].Surname == contact.Surname) && 
                        (contactLibrary.contactLibrarys[0].Lib[f - 65][i].Number == contact.Number))
                    {
                        contactLibrary.contactLibrarys[0].Lib[f - 65].RemoveAt(i);
                        Console.WriteLine("Deleteing successfully");
                        check = false;
                    }
                }                
            }
            else if ((f >= 1040) && (f <= 1071))
            {
                for (int i = 1; i < contactLibrary.contactLibrarys[1].Lib[f - 1040].Count; i++)
                {
                    if ((contactLibrary.contactLibrarys[1].Lib[f - 1040][i].Name == contact.Name) && 
                        (contactLibrary.contactLibrarys[1].Lib[f - 1040][i].Surname == contact.Surname) && 
                        (contactLibrary.contactLibrarys[1].Lib[f - 1040][i].Number == contact.Number))
                    {
                        contactLibrary.contactLibrarys[1].Lib[f - 1040].RemoveAt(i);
                        Console.WriteLine("Deleteing successfully");
                        check = false;
                    }
                }
            }
            else if ((f >= 48) && (f <= 57))
            {
                for (int i = 1; i < contactLibrary.contactLibrarys[2].Lib[f - 48].Count; i++)
                {
                    if ((contactLibrary.contactLibrarys[2].Lib[f - 48][i].Name == contact.Name) && 
                        (contactLibrary.contactLibrarys[2].Lib[f - 48][i].Surname == contact.Surname) && 
                        (contactLibrary.contactLibrarys[2].Lib[f - 48][i].Number == contact.Number))
                    {
                        contactLibrary.contactLibrarys[2].Lib[f - 48].RemoveAt(i);
                        Console.WriteLine("Deleteing successfully");
                        check = false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < contactLibrary.contactLibrarys[3].Lib[0].Count; i++)
                {
                    if ((contactLibrary.contactLibrarys[3].Lib[0][i].Name == contact.Name) && 
                        (contactLibrary.contactLibrarys[3].Lib[0][i].Surname == contact.Surname) && 
                        (contactLibrary.contactLibrarys[3].Lib[0][i].Number == contact.Number))
                    {
                        contactLibrary.contactLibrarys[3].Lib[0].RemoveAt(i);
                        Console.WriteLine("Deleteing successfully");
                        check = false;
                    }
                }
            }
            if (check)
            {
                Console.WriteLine("Contact not found");
            }
        }
    }
}

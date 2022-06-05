using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Sorter
    {
        public void Sort(ContactLibrary contactLibrary, Contact contact)
        {
            int f = (int)contact.Surname[0];
            if ((f >= 65) && (f <= 90))
            {
                contactLibrary.contactLibrarys[0].Lib[f - 65].Add(contact);
            }
            else if ((f >= 1040) && (f <= 1071))
            {
                contactLibrary.contactLibrarys[1].Lib[f - 1040].Add(contact);
            }
            else if ((f >= 48) && (f <= 57))
            {
                contactLibrary.contactLibrarys[2].Lib[f - 48].Add(contact);
            }
            else
            {
                contactLibrary.contactLibrarys[3].Lib[0].Add(contact);
            }            
        }
    }
}

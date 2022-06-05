using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Starter
    {
        public void Go()
        {
            bool flag = true;
            Initializer initializer = new Initializer();
            Contact[] ContactList = new Contact[33];
            ContactLibrary contactLibrary = new ContactLibrary();
            CultureLibrary en_US = new CultureLibrary();
            CultureLibrary ru_Ru = new CultureLibrary();
            CultureLibrary nums = new CultureLibrary();
            CultureLibrary other = new CultureLibrary();
            Sorter sorter = new Sorter();
            ConsoleServise consoleServise = new ConsoleServise();
                        
            initializer.InitializeContact(ContactList);
            initializer.InitializeCulture(en_US, 0);
            initializer.InitializeCulture(ru_Ru, 1);
            initializer.InitializeCulture(nums, 2);
            initializer.InitializeCulture(other, 3);
            contactLibrary.contactLibrarys.Add(en_US);
            contactLibrary.contactLibrarys.Add(ru_Ru);
            contactLibrary.contactLibrarys.Add(nums);
            contactLibrary.contactLibrarys.Add(other);

            for(int i = 0; i < ContactList.Length; i++)
            {
                sorter.Sort(contactLibrary, ContactList[i]);
            }

            while (flag)
            {
                flag = consoleServise.Do(flag, contactLibrary);
            }
        }
    }
}

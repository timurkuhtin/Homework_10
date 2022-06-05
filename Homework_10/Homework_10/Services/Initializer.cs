using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Initializer
    {
        public Contact[] InitializeContact(Contact[] ContactList)
        {
            ContactList[0] = new Contact("Ivan","Ivanov", 1111111111);
            ContactList[1] = new Contact("Ivan","Abramov", 1111111111);
            ContactList[2] = new Contact("Ivan","Zhuravlev", 1111111111);
            ContactList[3] = new Contact("Ivan","Platonov", 1111111111);
            ContactList[4] = new Contact("Ivan","Kravetc", 1111111111);
            ContactList[5] = new Contact("Ivan","Orlov", 1111111111);
            ContactList[6] = new Contact("Ivan","Korneev", 1111111111);
            ContactList[7] = new Contact("Ivan","Lyubimov", 1111111111);
            ContactList[8] = new Contact("Ivan","Stachevich", 1111111111);
            ContactList[9] = new Contact("Ivan","Baranov", 1111111111);
            ContactList[10] = new Contact("Ivan","Иванов", 1111111111);
            ContactList[11] = new Contact("Ivan","Абрамов", 1111111111);
            ContactList[12] = new Contact("Ivan","Журавлёв", 1111111111);
            ContactList[13] = new Contact("Ivan","Платонов", 1111111111);
            ContactList[14] = new Contact("Ivan","Кравец", 1111111111);
            ContactList[15] = new Contact("Ivan","Орлов", 1111111111);
            ContactList[16] = new Contact("Ivan","Корнеев", 1111111111);
            ContactList[17] = new Contact("Ivan","Любимов", 1111111111);
            ContactList[18] = new Contact("Ivan","Стахевич", 1111111111);
            ContactList[19] = new Contact("Ivan","Баранов", 1111111111);
            ContactList[20] = new Contact("Ivan","9Ivanov", 1111111111);
            ContactList[21] = new Contact("Ivan","1Ivanov", 1111111111);
            ContactList[22] = new Contact("Ivan","4Ivanov", 1111111111);
            ContactList[23] = new Contact("Ivan","5Ivanov", 1111111111);
            ContactList[24] = new Contact("Ivan","3Ivanov", 1111111111);
            ContactList[25] = new Contact("Ivan","0Ivanov", 1111111111);
            ContactList[26] = new Contact("Ivan","6Ivanov", 1111111111);
            ContactList[27] = new Contact("Ivan","8Ivanov", 1111111111);
            ContactList[28] = new Contact("Ivan","7Ivanov", 1111111111);
            ContactList[29] = new Contact("Ivan","2Ivanov", 1111111111);
            ContactList[30] = new Contact("Ivan","*Ivanov", 1111111111);
            ContactList[31] = new Contact("Ivan","+Ivanov", 1111111111);
            ContactList[32] = new Contact("Ivan","-Ivanov", 1111111111);
            return ContactList;
        }
        public CultureLibrary InitializeCulture(CultureLibrary lib, int i)
        {               
            int f = 0;
            if (i == 0)
            {
                string en = "abcdefghijklmnopqrstuvwxyz";
                foreach(char a in en)
                {
                    lib.Lib.Add(new List<Contact>());
                    lib.Lib[f].Add(new Contact(a));
                    f++;
                }
                f = 0;
            }
            else if (i == 1)
            {
                string ru = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
                foreach (char a in ru)
                {
                    lib.Lib.Add(new List<Contact>());
                    lib.Lib[f].Add(new Contact(a));
                    f++;
                }
                f = 0;
            }
            else if (i == 2)
            {
                string nums = "0123456789";
                foreach (char a in nums)
                {
                    lib.Lib.Add(new List<Contact>());
                    lib.Lib[f].Add(new Contact(a));
                    f++;
                }
                f = 0;
            }
            else if (i == 3)
            {
                lib.Lib.Add(new List<Contact>());
            }
            return lib;
        }

    }
}

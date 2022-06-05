using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class ContactLibrary
    {
        public List<CultureLibrary> contactLibrarys = new List<CultureLibrary>();

        public void Show(int i)
        {
            for(int j = 0; j < contactLibrarys[i].Lib.Count; j++)
            {
                if(contactLibrarys[i].Lib[j].Count != 1)
                {
                    for(int k = 1; k < contactLibrarys[i].Lib[j].Count; k++)
                    {
                        contactLibrarys[i].Lib[j][k].write();
                    }
                }
                
            }
        }
    }
}

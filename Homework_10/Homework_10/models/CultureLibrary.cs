using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class CultureLibrary
    {
        public List<List<Contact>> Lib = new List<List<Contact>>();
        public CultureLibrary(CultureLibrary lib)
        {
            this.Lib = lib.Lib;
        }
        public CultureLibrary()
        {
        }
    }
}

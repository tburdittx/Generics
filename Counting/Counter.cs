using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Counter<t>:ICountable
    {
        int count = 0;
        public void Add(t item)
        {
           count++;
        }
        public int Count()
        {
            return count;
        }
    }
}
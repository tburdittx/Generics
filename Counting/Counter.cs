using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Counter<t>
    {
        

        int AllApples = 0;
        int CountRed = 0;

        public int CountAllApples()
        {
            AllApples++;
            return AllApples;
        }

        public int CountRedOnly()
        {
          
            CountRed++;
            return CountRed;
        }
    }
}

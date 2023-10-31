using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    class Cywile : Mieszkaniec
    {
        public Cywile(int age1) : base(age1)
        {

        }

        public override string ToString()
        {
            return "Hello I am Cywil.";
        }
    }
}

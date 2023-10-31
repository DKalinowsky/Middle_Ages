using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    abstract class Obrońcy : Mieszkaniec
    {
        public Obrońcy(int age1) : base(age1)
        {

        }
        public virtual string ReadyToFight()
        {
            return "";
        }
        public override string ToString()
        {
            return "Hello I am Obronca ";
        }

    }
}

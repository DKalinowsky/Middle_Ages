using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    class Kusznicy : Obrońcy
    {
        public Kusznicy(int age1) : base(age1)
        {
        }
        public override string ReadyToFight()
        {
            return "My crosbow is under your command, and I am ready to fight for you.";
        }
        public override string ToString()
        {
            return "This is a Kusznik. ";
        }
    }
}

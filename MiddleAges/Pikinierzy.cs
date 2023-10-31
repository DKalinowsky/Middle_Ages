using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    class Pikinierzy : Obrońcy
    {
        public Pikinierzy(int age1) : base(age1)
        {
        }
        public override string ReadyToFight()
        {
            return "My pika is under your command, and i am ready to fight for you.";
        }
        public override string ToString()
        {
            return "Hello I am Pikinier ";
        }
    }
}

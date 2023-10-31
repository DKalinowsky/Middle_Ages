using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    class Mieszkaniec
    {
        public int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                if (value < 0 && value > 110)
                {
                    WriteLine("Error, this occupant is unborn or dead !!!");
                }
            }
        }
        public int Eat()
        {
            return age;
        }
        public Mieszkaniec(int age1)
        {
            age = age1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MiddleAges
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kusznicy> kusznicy = new List<Kusznicy> { new Kusznicy(21), new Kusznicy(18), new Kusznicy(26) };
            List<Mieszkaniec> mieszkancy = new List<Mieszkaniec> { new Cywile(7), new Cywile(17), new Cywile(77) };
            List<Obrońcy> obroncy = new List<Obrońcy> { new Pikinierzy(21), new Pikinierzy(18), new Pikinierzy(24) };

            WriteLine("Lista wzystkich kusznikow: ");
            foreach(var k in kusznicy)
            {
                obroncy.Add(k);
                WriteLine(k.ReadyToFight());
            }
            WriteLine("Lista wzystkich obroncow: ");
            foreach (var o in obroncy)
            {
                mieszkancy.Add(o);
                WriteLine(o.ReadyToFight());
            }
            int foodunits = 0;
            WriteLine("Lista wzystkich miszkancow z zapotrzebowaniem na jedzenie: ");
            foreach (var m in mieszkancy)
            {
                foodunits += m.Eat();
                WriteLine(m.ToString() + " I need " + m.Eat() + " food units.");
            }
            WriteLine("In total we need " + foodunits + " food units");
        }
    }
}


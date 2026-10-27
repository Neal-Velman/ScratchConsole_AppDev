using ScratchConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole
{
    public static class Week04
    {
        public static void Run()
        {
            DemoRefVsValTypes();
        }

        private static void DemoRefVsValTypes()
        {
            int x = 10;
            int y = x;
            y += 5;

            // What is x? 10
            // What is y? 15

            Dog d1 = new Dog() { Name = "Hank", Age = 9, Breed = "Pitty/Catahoola" };
            Dog d2 = d1;
            d2.Name = "Cleo";

            //What is the name of dog 1? It is now Cleo. Why?
            //What is the name of dog 2? It is now Cleo. Why?

            Fraction f1 = new Fraction() { WholeNumber = 7 };
            Fraction f2 = f1;
            f1.WholeNumber = 13;

            //What is the WholeNumber of f1? 13
            //What is the WholeNumber of f2? 7
        }
    }
}

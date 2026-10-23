using ScratchConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole
{
    internal static class Week03
    {
        public static void Run()
        {
            DemoDogs();
        }

        private static void DemoDogs()
        {
            Dog izzy = new Dog() { Name = "Isabella", Age = 15, Breed = "Black Lab" };
            Dog taTyr = new Dog() { Name = "Tyr", Age = 2, Breed = "Husky" };

            Dog piper = izzy + taTyr;

            Console.WriteLine($"d1: {izzy}");
            Console.WriteLine($"d2: {taTyr}");
            Console.WriteLine($"d3: {piper}");

            Dog izzy2 = new Dog() { Name = "Isabella", Age = 15, Breed = "Black Lab" };
            Console.WriteLine("Are d1 and d4 equal? " + (izzy == izzy2));
        }

        private static void DemoInterfaces()
        {

        }

        private static void DemoCollections()
        {
            List<int> list;
        }

        private static void DemoBasicLanguageFeatures()
        {
            // Increment / Decrement
            int counter = 0;

            // Increase the counter by 1
            counter = counter + 1;
            counter += 1;
            counter++;
            ++counter;

            // Postfix notation
            Console.WriteLine(counter);
            Console.WriteLine(counter++);
            Console.WriteLine(counter+"\n");

            // Prefix notation
            Console.WriteLine(counter);
            Console.WriteLine(++counter);
            Console.WriteLine(counter+"\n");

            // Decrease the counter by 1

            counter = counter - 1;
            counter -= 1;
            counter--;
            --counter;

            Console.WriteLine(counter);
            Console.WriteLine(counter--);
            Console.WriteLine(counter + "\n");

            // Prefix notation
            Console.WriteLine(counter);
            Console.WriteLine(--counter);
            Console.WriteLine(counter+"\n");



        }

        private static void DemoModels() {
            Movie movie = new Movie();
            int number = Movie.firstYear;

            //movie.SetTitle("Land of the Lost");
            movie.Year = 2009;

            Console.WriteLine($"Year: {movie.Year}");
        }
    }
}

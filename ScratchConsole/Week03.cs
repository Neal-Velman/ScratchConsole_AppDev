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
            DemoModels();
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

            movie.SetTitle("Land of the Lost");
            movie.Year = 2009;

            Console.WriteLine($"Year: {movie.Year}");
        }
    }
}

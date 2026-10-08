using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole
{
    public static class Week01
    {
        public static void Run()
        {
            DemoStrings();
        }

        public static void DemoStrings()
        {
            string words = "Hi. Cheese is your favorite?";
            char third = words[2];

            int countOfChars = words.Length;

            string expected = "John";
            Console.WriteLine("Enter the name \"John\": ");
            string? actual = Console.ReadLine();
            Console.WriteLine("Expected = Actual: " + (expected.ToLower() == actual?.ToLower()));
        }

        public static void DemoDataTypes()
        {
            // In Java, there are 8 basic data types
            // byte, short, int, long, float, double, boolean, char

            // C# has all of these types, and a little more
            byte b = 255; // In C#, byte is unsigned by default
            short sh = -100; // Same as Java
            int i = 2096; // Same as Java, and wipes
            long l = 1001032010321L; // Same as Java

            float f = 3.1415f;
            double d = 3.21029d;
            decimal dec = 1.20320438924382943293438293498329304093289340982893043823940m; // Java doesn't have this

            bool boo = true; // Different by a little
            char c = '?'; // Same as Java


            uint bigNum = 4294232323; // Java doesn't have unsigned primitaves.
            sbyte sb = -128; // This is a signed byte, the default for Java

            int? num = null; // Nullable primative, "?" works on ALL data types

            string? words = null;

            words?.IsWhiteSpace(); // Will avoid crashing the application if the string is null
            words!.IsWhiteSpace(); // ! indicates that the variable is NOT null, and CANNOT become null.
        }


    }
}

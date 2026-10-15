using CSC160_ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole
{
    internal static class Week02
    {
        internal static void Run()
        {
            DemoParse();
        }

        private static void DemoIEnumerable(IEnumerable<int> items)
        {
            items.Count();
        }

        private static void DemoPromptForMenuSelection()
        {
            string[] options = { "Play", "Options", "Credits", "Extras", "Achievements" };
            int choice = CIO.PromptForMenuSelection(options, false);

            if (choice > 0)
            {
                Console.WriteLine($"You chose #{choice}: {options[choice - 1]}");
            }
            else
            {
                Console.WriteLine($"You chose #{choice}: Have a great day!");
            }
        }

        private static void DemoParse()
        {
            // How to parse like a newb
            string input = "2";
            //This is the most literal version of Parse
            //int parsedNum = Int32.Parse(input);

            // The "sugary" version of Parse
            //int parsedNum = int.Parse(input);

            //TryParse uses the out keyword to pass by reference
            int parsedNum = -7;
            if (int.TryParse(input, out parsedNum))
            {
                Console.WriteLine($"The parsed num is: {parsedNum}.");
            }
            else
            {
                Console.WriteLine("An integer must be input to parse correctly.");
            }

        }
    }
}

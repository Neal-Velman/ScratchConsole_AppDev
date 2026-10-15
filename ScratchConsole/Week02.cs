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
            DemoPromptForMenuSelection();
        }

        private static void DemoPromptForMenuSelection()
        {
            string[] options = {"Play", "Options", "Credits", "Extras", "Achievements"};
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
    }
}

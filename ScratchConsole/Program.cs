using ScratchConsole.Delegates;

namespace ScratchConsole { 

    public class Program
    {

        // Delegates are great, but they're easy to break or misuse.

        //public static DemoDelegate? MyDemoDelegate { get; set; }

        // This is why events exist!

        public static event DemoDelegate? MyDemoEvent;


        private static void Main(String[] args) 
        {



            // Subscribe to the delegate
            Week04.Run();
            MyDemoEvent += Week03.Run;
            Week04.Run();
            //MyDemoDelegate += Week04.Run;
            MyDemoEvent += Week06.Run;
            Week04.Run();

            // Invoke the delegate
            //MyDemoDelegate.Invoke(); // This is the long form
            //MyDemoDelegate(); // This is the short form ... STILL NOT A METHOD THOUGH

            MyDemoEvent?.Invoke();
            Console.WriteLine();
            Week04.Unsubscribe();
            Week04.Unsubscribe();
            Week04.Unsubscribe();
            MyDemoEvent?.Invoke();
            Week04.Unsubscribe();

        }
    }
}
using ScratchConsole.Delegates;

namespace ScratchConsole { 

    public class Program
    {

        // Delegates are great, but they're easy to break or misuse.
        // This is why events exist.
        public static DemoDelegate? MyDemoDelegate { get; set; }
        private static void Main(String[] args)
        {
            // Subscribe to the delegate
            Week04.Run();
            MyDemoDelegate += Week03.Run;
            Week04.Run();
            //MyDemoDelegate += Week04.Run;
            MyDemoDelegate += Week06.Run;
            Week04.Run();

            // Invoke the delegate
            //MyDemoDelegate.Invoke(); // This is the long form
            //MyDemoDelegate(); // This is the short form ... STILL NOT A METHOD THOUGH

            MyDemoDelegate?.Invoke();
            Console.WriteLine();
            Week04.Unsubscribe();
            Week04.Unsubscribe();
            Week04.Unsubscribe();
            MyDemoDelegate?.Invoke();
            Week04.Unsubscribe();

        }
    }
}
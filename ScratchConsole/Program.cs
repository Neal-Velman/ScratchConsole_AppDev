public class Program
{
    private static void Main(String[] args)
    {

        // Declare a string variable to hold the user's name
        /*
         * Prompt the user for their name
         * Store their input in the name variable
         * Greet the user by their name
        */
        string? userName = null;
        Console.WriteLine("Enter your name: ");
        userName = Console.ReadLine();
        if (userName != null)
        {
            Console.WriteLine("Hello, " + userName + "!");
        }
        else
        {
            Console.WriteLine("No name entered.");
        }
    }
}
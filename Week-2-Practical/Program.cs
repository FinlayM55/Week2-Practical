class Program
{
    static void Main()
    {
        int option; 

        do
        {
       
            PrintMenu();

            option = InputOption();

            string message = GetMessage(option);

            Console.WriteLine($"Result: {message}");
            Console.WriteLine(); 

        } while (option != 0); 

        Console.WriteLine("Program exited successfully. Goodbye!");
    }
    static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish");
        Console.WriteLine("3. Hello in German");
        Console.WriteLine("4. Hello in Italian");
        Console.WriteLine("0. Exit application");

    }
    static int InputOption()
    {
        try
        {
            Console.WriteLine("Enter your choice: ");

            string input = Console.ReadLine();
            
            int choice = Convert.ToInt32(input);

            return choice;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
            return 0;
        }
        finally
        {
            Console.WriteLine("Cleanup complete.");
        }
    }
    static string GetMessage(int language)
    {
        switch (language)
        {
            case 0:
                return "Goodbye";
            case 1:
                return "Bonjour";
            case 2:
                return "Ola";
            case 3:
                return "Hallo";
            case 4:
                return "Ciao";
            default:
                return " Please enter a valid option";
        }
    }
}

//

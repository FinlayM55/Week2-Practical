// Tasks 1-4

/*class Program
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
*/


// Task 5
/* class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String Sentance (Each word must start with an Uppercase letter): )");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);

        Console.WriteLine($"Number of words: {wordCount}");
    }
       static int CountWords(string input)
    {
       int count = 0;

       foreach(char c in input)
        {
            if (char.IsUpper(c))
            {
                count++;
            }
        }
       return count;
    }
}
*/

// Task 6
/*class program
{  static void Main()
    
    {
        Console.WriteLine("Enter a String Sentance to Encrypt");
        string input = Console.ReadLine();

        Console.WriteLine("Enter number of roatations");
        int rotations = Convert.ToInt32(Console.ReadLine());

        string encrypted = Encrypt(input, rotations);

        Console.WriteLine($"The sentance you inputted is: {input}");
        Console.WriteLine($"Your encrypted string is {encrypted}");
    }
    static string Encrypt(string input, int rotations)
    {
        rotations = rotations % 26;

        char[] result = new char [input.Length];

        for(int i = 0; i < input.Length; i++) {
            
            char c = input[i];

            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                
                char encryptedChar = (char)((((c - baseChar) + rotations) % 26) + baseChar);
                result[i] = encryptedChar;
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);

    }
}
*/

// Task 7
/*class program
{
    static void Main()

    {
        Console.WriteLine("Enter a String Sentance to Decypher");
        string input = Console.ReadLine();

        Console.WriteLine("Enter number of roatations");
        int rotations = Convert.ToInt32(Console.ReadLine());

        string decypher = Decrypt(input, rotations);

        Console.WriteLine($"The sentance you inputted is: {input}");
        Console.WriteLine($"Your encrypted string is {decypher}");
    }
    static string Decrypt(string input, int rotations)
    {
        rotations = ((-rotations % 26) + 26) % 26;

        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {

            char c = input[i];

            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';

                char encryptedChar = (char)((((c - baseChar) + rotations) % 26) + baseChar);
                result[i] = encryptedChar;
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);

    }
}
*/
//Task 8
/* class program
{
    static void Main()

    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Encrypt Text");
        Console.WriteLine("2. Decrypt Text");
        Console.WriteLine("3. Exit");

        String input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("Enter a String Sentance to Encrypt");
            string message = Console.ReadLine();

            Console.WriteLine("Enter number of roatations");
            int rotations = Convert.ToInt32(Console.ReadLine());

            string encrypted = Encrypt(message, rotations);

            Console.WriteLine($"The sentance you inputted is: {message}");
            Console.WriteLine($"Your encrypted string is {encrypted}");
        }
        else if (input == "2")
        {
            Console.WriteLine("Enter a String Sentance to Decypher");
            string message = Console.ReadLine();

            Console.WriteLine("Enter number of roatations");
            int rotations = Convert.ToInt32(Console.ReadLine());

            string decypher = Decrypt(message, rotations);

            Console.WriteLine($"The sentance you inputted is: {message}");
            Console.WriteLine($"Your encrypted string is {message}");
        }
        else if (input == "3")
        {
            Console.WriteLine("Exiting application");
            Environment.Exit(0);
        }
    }
    static string Encrypt(string input, int rotations)
    {
        rotations = rotations % 26;

        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {

            char c = input[i];

            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';

                char encryptedChar = (char)((((c - baseChar) + rotations) % 26) + baseChar);
                result[i] = encryptedChar;
            }
            else
            {
                result[i] = c;
            }
        }
        return new string(result);
    }
    static string Decrypt(string input, int rotations)
    {
        rotations = ((-rotations % 26) + 26) % 26;

        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {

            char c = input[i];

            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';

                char encryptedChar = (char)((((c - baseChar) + rotations) % 26) + baseChar);
                result[i] = encryptedChar;
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);

    }
}
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Circle Area Calculator ===");

        double radius = -1; 

        while (true)
        {
            try
            {
                Console.WriteLine("Enter the circle radius (0 to exit): ");
                radius = Convert.ToDouble(Console.ReadLine());

                if (radius == 0)
                {
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;
                }
                else if (radius < 0)
                {
                    Console.WriteLine("Radius cannot be negative. Try again.");
                    continue;
                }

                double area = CircleArea(radius);
                Console.WriteLine($"The area of a circle with radius {radius} is {area:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
    static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}











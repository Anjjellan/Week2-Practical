
 /* 
  * Practical 2
  * Information: Methods Demo
  * Version 1
  * Author : Anjjellan Sam Santhankumar
  * Date : Sepetember
  */

    Main();
    void Main()
    {
        int options;
        do
        {
            PrintMenu();
            options = GetOption();
            string reply = GetMessage(options);
            Console.WriteLine(reply);
            Console.WriteLine();
        } while (options != 0);

    }

    void PrintMenu()
    {
        Console.WriteLine("1. Hello in French");
        Console.WriteLine("2. Hello in Spanish");
        Console.WriteLine("3. Hello in German");
        Console.WriteLine("4. Hello in Italian");
        Console.WriteLine("0. Exit application");
    }
 
    int GetOption()
    {
        while (true)
        {
            Console.WriteLine("Please select an option from the menu:");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input. Please enter a number within the valid range.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
           
        }
    }

    string GetMessage(int options)
    {
        switch (options)
        {
            case 1:
                return "Bonjour";   // French
            case 2:
                return "Hola";      // Spanish
            case 3:
                return "Hallo";     // German
            case 4:
                return "Ciao";      // Italian
            case 0:
                return "Goodbye!";
            default:
                return "Please enter a valid option";
        }

    }


   


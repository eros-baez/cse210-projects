using System;

class Program
{
    static void Main(string[] args)
    {
        void WelcomeMessage ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string DisplayUserName (string userName)
        {
            return $"Hello {userName}.";
        }

        string DisplayNumber (int userNumber)
        {
            return $"Your favorite number is: {userNumber}";
        }

        string DisplaySquaredNumber (int userNumber, string userName)
        {
            double squared = Math.Pow(userNumber, 2);

            return $"Brother {userName}, the square of your number is: {squared}";
        }

        WelcomeMessage();

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("");

////////////////////////////////////////////////////////////////////////////////
 
        Console.WriteLine(DisplayUserName (userName));
        Console.WriteLine(DisplayNumber (userNumber));
        Console.WriteLine(DisplaySquaredNumber(userNumber, userName));

    }
}
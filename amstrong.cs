using System;

public class Armstrong
{
    public const int DIGITSEPERATOR = 10;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int userInput = int.Parse(Console.ReadLine());
        int number = userInput;
        int sum = 0;
        int length = number.ToString().Length;

        while (number > 0)
        {
            int remainder = number % DIGITSEPERATOR;
            int digitPower = 1;
            for (int i = 0; i < length; i++)
            {
                digitPower *= remainder;
            }
            sum = sum + digitPower;
            number = number / DIGITSEPERATOR;
        }

        if (sum == userInput)
        {
            Console.WriteLine("The given number {0} is an Armstrong number", userInput);
        }
        if (sum != userInput)
        {
            Console.WriteLine("The given number {0} is NOT an Armstrong number", userInput);
        }
    }
}

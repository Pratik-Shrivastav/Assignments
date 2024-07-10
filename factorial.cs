using System;

public class Factorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int userInput = int.Parse(Console.ReadLine());
        int product = 1;
	for(int i =1; i<=userInput; i++)
	{
		product = product * i;
	}
	Console.WriteLine("The facrorial of {0} is {1}", userInput, product);
    }
}

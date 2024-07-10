using System;

public class CheckPrime
{
    public const int DIVISOR = 2;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int userInput = int.Parse(Console.ReadLine());
        int midPoint = userInput/DIVISOR;
	int flagPrimeCheck = 0;
	for(int i = 2; i<=midPoint; i++)
	{
		if(userInput%i == 0)
		{
			flagPrimeCheck = 1;
		}		
	}
	if(flagPrimeCheck==0)
	{
		Console.WriteLine("The number {0} is Prime",userInput);
	}
	if(flagPrimeCheck!=0)
	{
		Console.WriteLine("The number {0} is NOT Prime",userInput);
	}
    }
}

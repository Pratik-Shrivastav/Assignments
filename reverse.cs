using System;
public class ReverseNumber
{
	public const int DIGITSEPERATOR = 10;
	static void Main(string[] args)
	{
		Console.WriteLine("Enter a number");
		int number;
		number = int.Parse(Console.ReadLine());
		int num = number;
		int reverse = 0;
		

		while(number > 0)
		{
			int remainder = number % DIGITSEPERATOR;
			reverse = reverse * DIGITSEPERATOR + remainder;
			number = number / DIGITSEPERATOR;
		}

		Console.WriteLine("Reverse of {0} is {1}", num, reverse);
	}
}
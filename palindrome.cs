using System;
public class CheckPalindrome
{
    public const int DIVISOR= 2;
    static void Main(string[] args)
    {
	Console.WriteLine("Enter the Number:");        
	String userInput = Console.ReadLine();
	if(userInput.Length % DIVISOR == 0)
	{
		Console.WriteLine(EvenPalindromeCheck(userInput));
	}
	if(userInput.Length % DIVISOR != 0)
	{
		Console.WriteLine(OddPalindromeCheck(userInput));
	} 
    }
	public static String OddPalindromeCheck(String number)
	{
		for(int i=0; i < (number.Length)/2 ; i++)
		{
			if(number[i] != number[number.Length -i-1])
			{
				return "The number is Not palindrome";
			}
		}
		return "The Number is Palindrome";
	}

	public static String EvenPalindromeCheck(String number)
	{
		for(int i=0; i <= (number.Length)/2 ; i++)
		{
			if(number[i] != number[number.Length -i-1])
			{
				return "The number is Not palindrome";
			}
		}
		return "The Number is Palindrome";
	}
}

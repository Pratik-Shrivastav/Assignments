using System;

    public class CommandLineArgs
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                int marks = int.Parse(args[i]);
                numbers[i] = marks;
            }
            Console.WriteLine("The Sum of numbers is " +Sum(numbers));
            Console.WriteLine("The Average of numbers is " +Average(numbers));
	    Console.WriteLine("The Minimum of numbers is "+Minimum(numbers));
	    Console.WriteLine("The Maximum of numbers is "+Maximum(numbers));
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;

            }
            return sum;
        }

        public static float Average(int[] numbers)
        {
            float totalSum = Sum(numbers);
            float averageOfNumbers = totalSum / numbers.Length;
            return averageOfNumbers;
        }
	
	
        public static float Minimum(int[] numbers)
        {
        	int miniNumber = 10000000;
		for (int i = 0; i < numbers.Length; i++)
		{
    			if (numbers[i] <= miniNumber)
    			{
        			miniNumber = numbers[i];
    			}
		}
		return miniNumber;
		
        }

	public static float Maximum(int[] numbers)
        {
        	int maxNumber = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
    			if (numbers[i] >= maxNumber)
    			{
        			maxNumber = numbers[i];
    			}
		}
		return maxNumber;
		
        }

    }

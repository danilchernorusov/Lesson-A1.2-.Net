using System;

public class Program
{
    // The main function
    public static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter {i + 1} number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int numderGcd = Gcd3Number(numbers[0], numbers[1], numbers[2]);

        Console.Write("GCD numbers ");
        foreach (int number in numbers)
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine($"equals {numderGcd}.");
    }

    // Function for finding GCD 3 number
    public static int Gcd3Number(int number1, int number2, int number3)
    {
        int numder1Gcd = gcd2Number(number1, number2);
        int numder2Gcd = gcd2Number(numder1Gcd, number3);

        return numder2Gcd;
    }

    // Function for finding GCD 2 number
    public static int gcd2Number(int number1, int number2)
    {
        if (number2 == 0)
        {
            return Math.Abs(number1);
        }

        return gcd2Number(number2, number1 % number2);
    }
}
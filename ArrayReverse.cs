using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        int sum = 0;

        Console.WriteLine("Enter the values:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine("\nSum of array = " + sum);

        Console.WriteLine("Array in reverse order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Define an array to store 10 integer values.
        int[] numbers = new int[10];

        // Step 2: Fill the array using a for loop and print the elements using a foreach loop.
        Console.WriteLine("Please enter 10 integer numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nEntered numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Step 3: Add a new value from the user to the array (as the 11th element).
        Console.Write("\nEnter a new number (11th element): ");
        int newNumber = Convert.ToInt32(Console.ReadLine());

        int[] extendedNumbers = new int[numbers.Length + 1];
        Array.Copy(numbers, extendedNumbers, numbers.Length);
        extendedNumbers[10] = newNumber;

        Console.WriteLine("\nUpdated array:");
        foreach (int num in extendedNumbers)
        {
            Console.WriteLine(num);
        }

        // Step 4: Sort the array in descending order and print it.
        Console.WriteLine("\nArray sorted in descending order:");
        var sortedNumbers = extendedNumbers.OrderByDescending(n => n).ToArray();
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
using System;
 
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The square of the number is: {number * number}");
                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        
        while (true)
        {
            // Step 1: Ask if user wants to produce a car
            Console.WriteLine("Do you want to produce a car? (e/h):");
            string answer = Console.ReadLine().ToLower();

            if (answer == "h") // No, exit the loop
            {
                break;
            }
            else if (answer == "e") // Yes, continue producing cars
            {
                Car car = new Car();

                // Step 3: Set the production date
                car.ProductionDate = DateTime.Now;

                // Get the rest of the car properties from the user
                Console.WriteLine("Enter serial number:");
                car.SerialNumber = Console.ReadLine();

                Console.WriteLine("Enter brand:");
                car.Brand = Console.ReadLine();

                Console.WriteLine("Enter model:");
                car.Model = Console.ReadLine();

                Console.WriteLine("Enter color:");
                car.Color = Console.ReadLine();

                // Step 4: Handle invalid input for DoorCount
                while (true)
                {
                    Console.WriteLine("Enter door count:");
                    string doorCountInput = Console.ReadLine();
                    
                    try
                    {
                        car.DoorCount = int.Parse(doorCountInput);
                        break; // Exit the loop if successful
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number for door count.");
                    }
                }

                // Step 5: Add the car to the list
                cars.Add(car);

                // Step 6: Ask if the user wants to produce another car
                Console.WriteLine("Do you want to produce another car? (e/h):");
                string continueAnswer = Console.ReadLine().ToLower();

                if (continueAnswer == "h")
                {
                    break;
                }
            }
            else
            {
                // Handle invalid input for produce question
                Console.WriteLine("Invalid response. Please enter 'e' for yes or 'h' for no.");
            }
        }

        // Step 7: Print serial numbers and brands of all cars
        Console.WriteLine("\nCars Produced:");
        foreach (var car in cars)
        {
            Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
        }
    }
}
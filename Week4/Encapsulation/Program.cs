class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Mercedes-Benz", "S-Class", "Black", 4);
        Console.WriteLine(car1.CarDetails());

        Car car2 = new Car("Toyota", "Corolla", "White", 3);
        Console.WriteLine(car2.CarDetails());
    }
}

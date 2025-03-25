public class Car
{
    // field
    private int doorNumber; 

    // Constructor
    public Car(string brand, string model, string color, int doorNumber)
{
    this.Brand = brand;
    this.Model = model;
    this.Color = color;
    this.DoorNumber = doorNumber;
}
    // Properties
    public string? Brand { get ; set; } = " ";
    public string? Model { get; set; } = " ";
    public string? Color { get; set; } = " ";
    public int DoorNumber 
    { 
    get {return doorNumber;}
    set
    {
        if(value ==2 || value ==4)
        {
            doorNumber = value; 
        }
        else
        {
            Console.WriteLine("Door number must be either 2 or 4. Assigning -1 by default.");
            doorNumber = -1;
        }
    }
    }
    //Methods
    public string CarDetails()
    {
        return $"Brand: {Brand}, Model: {Model}, Color: {Color}, Door Number: {DoorNumber}";
    }
}
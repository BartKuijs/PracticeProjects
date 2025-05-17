

Book book = new Book();

book.ProductName = "A Tale Of Two Cities";
InventoryItem boooooook = new Book();

Car car = new Car();

car.Manufacturer = "Opel";



public interface IVehicleInformation
{
    void StartEngine();
}

public abstract class Vehicle
{
    
    public string VIN { get; set; }
    public string Manufacturer { get; set; }
    public int YearManufactured { get; set; }
    public string Model { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfWheels { get; set; } = 4;
}





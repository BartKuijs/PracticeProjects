public class ExcavatorModel : InventoryItemModel, IRentalable
{
    public void Dig()
    {
        Console.WriteLine("I am digging");
    }

    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This Excavator has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock += 1;
        Console.WriteLine("This Excavator has been returned");
    }
}



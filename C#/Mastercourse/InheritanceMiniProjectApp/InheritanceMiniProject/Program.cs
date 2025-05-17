


using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

List<IRentalable> rentables = new List<IRentalable> ();
List<IPurchasable> purchasables = new List<IPurchasable>();

var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima", QuantityInStock = 10 };
var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350, QuantityInStock = 999 };
var excavator = new ExcavatorModel { ProductName = "ExcavaTOR!", QuantityInStock = 2 };

rentables.Add (vehicle);
rentables.Add(excavator);

purchasables.Add (book);
purchasables.Add(vehicle);

Console.Write("Do you want to rent or buy something? (rent, buy) ");
string decision = Console.ReadLine (); 

if(decision.ToLower() == "rent")
{
    foreach(var item in rentables)
    {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do You Want to rent this item? y/n ");
        string wantToRent = Console.ReadLine ();

        if(wantToRent.StartsWith('y')|| wantToRent.StartsWith('Y'))
        {
            item.Rent();
        }

        Console.Write("Do You Want to return this item? y/n ");
        string wantToReturn = Console.ReadLine();

        if (wantToReturn.StartsWith('y') || wantToReturn.StartsWith('Y'))
        {
            item.ReturnRental();
        }

    }
}
else
{
    foreach(var item in purchasables)
    {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do You Want to purchase this item? y/n ");
        string wantToPurchase = Console.ReadLine();

        if (wantToPurchase.StartsWith('y') || wantToPurchase.StartsWith('Y'))
        {
            item.Purchase();
        }
    }
}
Console.WriteLine("We are done.");



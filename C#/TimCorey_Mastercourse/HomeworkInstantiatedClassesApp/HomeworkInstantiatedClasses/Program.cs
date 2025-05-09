

using HomeworkInstantiatedClasses;


var person = new PersonInformation();
var address = new AddressInformation();

Console.Write("What is your first name? ");
person.FirstName = Console.ReadLine();
Console.Write("What is your last name? ");
person.LastName = Console.ReadLine();
Console.Write("What is your phone number? ");
person.PhoneNumber = Console.ReadLine();

Console.Write("What is your postal code? ");
address.InvoicePostalCode = Console.ReadLine();
Console.Write("What is your house number? ");
address.InvoiceNumber = Console.ReadLine();
Console.Write("What is your street? ");
address.InvoiceStreet = Console.ReadLine();
Console.Write("What is your city? ");
address.InvoiceCity = Console.ReadLine();
Console.Write("What is your coutry? ");
address.InvoiceCountry = Console.ReadLine();


Console.Write("Is you shipping address the same as your invoice address? ");
string shippingAndInvoiceText = Console.ReadLine();
shippingAndInvoiceText = shippingAndInvoiceText.ToLower();

if(shippingAndInvoiceText != null && shippingAndInvoiceText.StartsWith('n'))
{
    person.ShippindAddressSameAsInvoiceAddress = false;
    Console.Write("What is your shipping postal code? ");
    address.ShippingPostalCode = Console.ReadLine();
    Console.Write("What is your shipping house number? ");
    address.ShippingNumber = Console.ReadLine();
    Console.Write("What is your shipping street? ");
    address.ShippingStreet = Console.ReadLine();
    Console.Write("What is your shipping city? ");
    address.ShippingCity = Console.ReadLine();
    Console.Write("What is your shipping coutry? ");
    address.ShippingCountry = Console.ReadLine();
}
else
{
    person.ShippindAddressSameAsInvoiceAddress= true;
    address.ShippingCity = address.InvoiceCity;
    address.ShippingCountry = address.InvoiceCountry;
    address.ShippingNumber = address.InvoiceNumber;
    address.ShippingStreet = address.InvoiceStreet;
    address.ShippingPostalCode = address.InvoicePostalCode;
}

Console.WriteLine($"Hello {person.FirstName} {person.LastName}. Your phone number is: {person.PhoneNumber}");
Console.WriteLine("Your shipping address is: ");
Console.WriteLine($"{address.ShippingStreet} {address.ShippingNumber}, {address.ShippingPostalCode} {address.ShippingCity} in {address.ShippingCountry}");



Console.WriteLine("Your invoice address is: ");

Console.WriteLine($"{address.InvoiceStreet} {address.InvoiceNumber}, {address.InvoicePostalCode} {address.InvoiceCity} in {address.InvoiceCountry}");





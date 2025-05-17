






using DataAccesLibrary;
using DataAccesLibrary.Models;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static CosmosDBDataAccess db;
    private static async void Main(string[] args)
    {
        var c = GetCosmosInfo();
        db = new CosmosDBDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName);

        var user = new ContactModel();
        string id = "";
        //await CreateContact(user);
        //await GetAllContacts();
        //GetContactById(id);
        //await UpdatContactsFirstName("Bart", id);

        //await RemovePhoneNumberFromUser("555-1212", id);

        // await RemoveUser(id, "Kuijs")
        Console.WriteLine("Done processing CosmosDB");

    }

    public static async Task RemoveUser(string id, string lastName)
    {
        await db.DeleteRecordAsync<ContactModel>(id, lastName);
    }
    public static async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
    {
        var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

        contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber == phoneNumber).ToList();

        await db.UpsertRecordAsync(contact);

    }
    private static async Task UpdatContactsFirstName(string firstName, string id)
    {
        var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

        contact.FirstName = firstName;

        await db.UpsertRecordAsync<ContactModel>(contact);

    }
    private static async Task GetContactById(string id)
    {
        var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

        Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
    }
    private static async Task GetAllContacts()
    {
        var contacts = await db.LoadRecordsAsync<ContactModel>();

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        }
    }

    private static async Task CreateContact(ContactModel contact)
    {
      await db.UpsertRecordAsync(contact);
    }

    private static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosInfo()
    {
        (string endpointUrl, string primaryKey, string databaseName, string containerName) output;

        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();
        output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointUrl");
        output.primaryKey = config.GetValue<string>("CosmosDB:PrimaryKey");
        output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName");
        output.containerName = config.GetValue<string>("ContainerName");



        return output;
    }
}
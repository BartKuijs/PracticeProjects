
using DataAccesLibrary;
using DataAccesLibrary.Models;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static MongoDBDataAccess db;
    private static readonly string tableName = "Contacts";
    private static void Main(string[] args)
    {

        db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

        var contact = new ContactModel
        {
            FirstName = "Charity",
            LastName = "Corey",
            
            
        };

        contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
        contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "bwkuijs@gmail.com" });
        contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
        contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

        //CreateContact(contact);

        //GetAllContacts();
        //GetContactById("1bd5e7d3-3367-4d3d-b73e-7271b4d4fb91");
        string id = "1bd5e7d3-3367-4d3d-b73e-7271b4d4fb91";

        //UpdatContactsFirstName("Bartjebibo", "1bd5e7d3-3367-4d3d-b73e-7271b4d4fb91");
        //RemovePhoneNumberFromUser("555-1212", "1bd5e7d3-3367-4d3d-b73e-7271b4d4fb91");
        //GetContactById("1bd5e7d3-3367-4d3d-b73e-7271b4d4fb91");

        RemoveUser(id);

        Console.WriteLine("Done processing MongoDB");
        
    }

    public static void RemoveUser(string Id)
    {
        Guid guid = new Guid(Id);
        db.DeleteRecord<ContactModel>(tableName, guid);
    }
    public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

        db.UpsertRecord(tableName, contact.Id, contact);

    }
    private static void UpdatContactsFirstName(string firstName, string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        contact.FirstName = firstName;

        db.UpsertRecord(tableName, contact.Id, contact);

    }
    private static void GetContactById(string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        int numberOfPhoneNumbers = contact.PhoneNumbers.Count();
        for(int i = 0; i < numberOfPhoneNumbers; i++)
        {
            Console.WriteLine(contact.PhoneNumbers[i].PhoneNumber);
        }
    }
    private static void GetAllContacts()
    {
        var contacts = db.LoadRecords<ContactModel>(tableName);
        
        foreach(var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            int numberOfEmailAddresses = contact.EmailAddresses.Count();
            for(int i = 0; i < numberOfEmailAddresses; i++)
            {
                Console.WriteLine(contact.EmailAddresses[i].EmailAddress);
            }
        }
    }

    private static void CreateContact(ContactModel contact)
    {
        db.UpsertRecord(tableName, contact.Id, contact);
    }
     
    private static string? GetConnectionString(string connectionStringName = "Default")
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();

        return config.GetConnectionString(connectionStringName);
    }
}
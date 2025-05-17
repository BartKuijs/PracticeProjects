





using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

internal class Program
{
    private static IConfiguration _config;
    private static string textFile;
    private static string csvFile;
    private static TextFileDataAccess db = new TextFileDataAccess();
    private static void Main(string[] args)
    {
        InitializeConfiguration();
        textFile = _config.GetValue<string>("TextFile");
        csvFile = _config.GetValue<string>("CsvFile");
        

        ContactModel user1 = new ContactModel();
        user1.FirstName = "Bart";
        user1.LastName = "Kuijs";
        user1.EmailAddresses.Add("bartkuijs@live.nl");
        user1.EmailAddresses.Add("bwkuijs@gmail.com");
        user1.PhoneNumbers.Add("555-1212");
        user1.PhoneNumbers.Add("555-1234");

        ContactModel user2 = new ContactModel();
        user2.FirstName = "Willem";
        user2.LastName = "Kuijs";
        user2.EmailAddresses.Add("willem@live.nl");
        user2.EmailAddresses.Add("bwkuijs@gmail.com");
        user2.PhoneNumbers.Add("555-1212");
        user2.PhoneNumbers.Add("555-9876");

        CreateContact(user1, csvFile);
        //CreateContact(user2);

        //UpdateContactsFirstName("Bart", "Bartjebibo");

        //GetAllContacts();
        //RemovePhoneNumberFromUser("555-1234");
        //RemoveUser();


    }

    public static void RemoveUser(string file)
    {
        var contacts = db.ReadAllRecords(file);
        contacts.RemoveAt(0);

        db.WriteAllRecords(contacts, file);
    }


    private static void RemovePhoneNumberFromUser(string phonenumber, string file)
    {
        var contacts = db.ReadAllRecords(file);
        
        foreach(var contact in contacts)
        {
            int NumberOfPhoneNumbers = contact.PhoneNumbers.Count;
            for(int i = 0; i < NumberOfPhoneNumbers; i++)
            {
                if (contact.PhoneNumbers[i] == phonenumber)
                {
                    contact.PhoneNumbers.RemoveAt(i);
                }
            }
        }
        db.WriteAllRecords(contacts, file);
    }

    private static void UpdateContactsFirstName(string FirstNameOld, string FirstNameNew, string file)
    {
        var contacts = db.ReadAllRecords(file);
        int AmountOfContacts = contacts.Count;
        for(int i = 0;i<AmountOfContacts;i++)
        {
            if (contacts[i].FirstName == FirstNameOld)
            {
                contacts[i].FirstName = FirstNameNew;
            }
        }
        db.WriteAllRecords(contacts, file);

    }

    private static void GetAllContacts(string file)
    {
        var contacts = db.ReadAllRecords(file);

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName}");
        }
    }
    private static void CreateContact(ContactModel contact, string file)
    {
        var contacts = db.ReadAllRecords(file);

        contacts.Add(contact);
        db.WriteAllRecords(contacts, file);
    }


    private static void InitializeConfiguration()
    {


        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        _config = builder.Build();

    }
}
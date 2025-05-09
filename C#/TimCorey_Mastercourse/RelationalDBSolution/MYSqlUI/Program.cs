
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MySqlUI
{
    class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = GetConnectionString();
            if (connectionString == null)
            {
                throw new ArgumentException("No connectionstring found.");
            }

            var sql = new MySqlCrud(connectionString);

            //ReadAllContacts(sql);

            //ReadContact(sql, 2);

            //CreateNewContact(sql);

            //UpdateContact(sql);


            //RemovePhoneNumberFromContact(sql, 1, 1);
            //ReadAllContacts(sql);
            Console.WriteLine("Done Processing MySQL");




        }
        private static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
        }
        private static void UpdateContact(MySqlCrud sql)
        {
            var contact = new BasicContactModel
            {
                Id = 1,
                FirstName = "Bart",
                LastName = "Kuijs"
            };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(MySqlCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel
                {
                    FirstName = "Charity",
                    LastName = "Corey"
                }

            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@timothycorey.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "555-1234" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-7777" });

            sql.CreateContact(user);
        }
        private static void ReadAllContacts(MySqlCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(MySqlCrud sql, int contactID)
        {
            var contact = sql.GetFullContactById(contactID);

            Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");

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
}
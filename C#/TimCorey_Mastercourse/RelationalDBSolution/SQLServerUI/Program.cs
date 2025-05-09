using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace SQLServerUI
{
    class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = GetConnectionString();
            if(connectionString == null)
            {
                throw new ArgumentException("No connectionstring found.");
            }

            var sql = new SqlCrud(connectionString);

            //ReadAllContacts(sql);

            //ReadContact(sql, 2);

            //CreateNewContact(sql);

            //UpdateContact(sql);

            //RemovePhoneNumberFromContact(sql, 1, 1);

            Console.WriteLine("Done Processing");




        }
        private static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
        }
        private static void UpdateContact(SqlCrud sql)
        {
            var contact = new BasicContactModel
            {
                Id = 1,
                FirstName = "Bart",
                LastName = "Kuijs"
            };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(SqlCrud sql)
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
        private static void ReadAllContacts(SqlCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(SqlCrud sql, int contactID)
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
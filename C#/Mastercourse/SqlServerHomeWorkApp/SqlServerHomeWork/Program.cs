
using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;




namespace SqlServerHomeWork
{
    class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = GetConnectionString();
            if (connectionString == null)
            {
                throw new ArgumentException("No connection string");
            }

            var sql = new SqlCrud(connectionString);

            sql.AddPerson("Andrea", "Kivits");

            var rows = sql.LookUpPeople();
            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }











        }

        private static string? GetConnectionString(string connectionString = "Default")
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            
            var config = builder.Build();

            return config.GetConnectionString(connectionString);
            
        }

    }
}
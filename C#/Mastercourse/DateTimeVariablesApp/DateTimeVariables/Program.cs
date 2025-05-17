

using System.Globalization;
using System.Xml;

DateTime today = DateTime.UtcNow;

// DateTime birthday = DateTime.Parse("23/7/1990");

// DateTime birthday = DateTime.ParseExact("23/07/1990", "d/M/yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(birthday);

Console.WriteLine(today.ToString("dd MMMM, yyyy HH:mm tt zzz"));



DateTime yesterday = DateTime.Now.AddDays(-1);
DateTime tomorrow = DateTime.Now.AddDays(+1);
DateTime today = DateTime.Today;

DateTime birthday = DateTime.Parse("23/07/1990");

Console.WriteLine(yesterday);
Console.WriteLine(today);
Console.WriteLine(tomorrow);
Console.WriteLine(birthday.ToString("d"));

DateTime yesterdayDateTime = DateTime.Now.AddDays(-1);
DateOnly yesterday = DateOnly.FromDateTime(yesterdayDateTime);

Console.WriteLine(yesterday);
Console.WriteLine(yesterdayDateTime);

DateOnly reply = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(reply);
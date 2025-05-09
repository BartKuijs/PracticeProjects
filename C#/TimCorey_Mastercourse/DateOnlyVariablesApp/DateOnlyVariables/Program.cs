
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("23/07/1990");

Console.WriteLine(birthday.ToString("dd MMMM, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");
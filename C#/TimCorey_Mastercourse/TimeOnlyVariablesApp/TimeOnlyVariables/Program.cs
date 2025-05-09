

TimeOnly opensAt = TimeOnly.Parse("8:00 AM");

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now.AddHours(+5));

Console.WriteLine(opensAt);
Console.WriteLine(rightNow);





TimeOnly opensAt = TimeOnly.Parse("08:00");
TimeOnly closesAt = opensAt.AddHours(9);
TimeOnly someTime = closesAt.AddMinutes(-20);

Console.WriteLine(opensAt);
Console.WriteLine(closesAt);
Console.WriteLine(someTime);




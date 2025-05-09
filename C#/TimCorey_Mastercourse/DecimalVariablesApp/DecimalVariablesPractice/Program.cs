

decimal bankAccountBalance = 538.55M;
decimal apple = 1.29M;
decimal correctAnswer = bankAccountBalance / apple;

Console.WriteLine("If an apple cost 1.29 and you have 538.55 in your bank account. " +
    "How many apples would you be able to buy?");

string yourAnswer = Console.ReadLine();
Console.WriteLine($"Your answer is: {yourAnswer}");
Console.WriteLine($"The correct answer is: {correctAnswer}");




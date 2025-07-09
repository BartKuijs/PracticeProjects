
using System.Linq.Expressions;
int randomMonth = Random.Shared.Next(1, 13);
int randomDay = Random.Shared.Next(1, DateTime.DaysInMonth(2025, randomMonth) + 1);

DateOnly randomDate = new DateOnly(2025, randomMonth, randomDay);

int inputMonth;
int inputDay;
bool correctDayGuess = false;
bool correctMonthGuess = false;
DateOnly inputDate;
do
{
    Console.Write("Please enter a day of the month as a number: ");
    string inputDayText = Console.ReadLine();
    int.TryParse(inputDayText, out inputDay);
    if ((inputDay > 0 && inputDay <= 31))
    {
        correctDayGuess = true;
        while (correctMonthGuess == false)
        {
            Console.WriteLine();
            Console.Write("Please enter a month in number format: ");
            string inputMonthText = Console.ReadLine();
            int.TryParse(inputMonthText, out inputMonth);
            if ((inputMonth > 0 && inputMonth <= 12) && inputDay <= DateTime.DaysInMonth(2025, inputMonth))
            {
                correctMonthGuess = true;
                inputDate = new DateOnly(2025, inputMonth, inputDay);
                if (randomDate.Equals(inputDate) || randomDate.Equals(inputDate.AddDays(1)) ||
                    randomDate.Equals(inputDate.AddDays(2)) || randomDate.Equals(inputDate.AddDays(3)) ||
                    randomDate.Equals(inputDate.AddDays(4)) || randomDate.Equals(inputDate.AddDays(5)))
                {
                    Console.WriteLine(
                        $"""
                          You Win!
                          Your guess was: {inputDate.ToString()}
                          The correct date was: {randomDate.ToString()}
                          You are within 5 days with your guess!!!
                          """);
                }
                else if (randomDate.CompareTo(inputDate) > 0)
                {
                    Console.WriteLine(
                $"""
                            You lost!
                            Your guess was: {inputDate.ToString()}
                            The correct date was: {randomDate.ToString()}
                            Your guess was after the date!
                           """);
                }
                else
                {
                    Console.WriteLine(
                        $"""
                You lost!
                Your guess was: {inputDate.ToString()}
                The correct date was: {randomDate.ToString()}
                You were to far from the date with your guess!
                """);
                }
            }
            else if ((inputMonth > 0 && inputMonth <= 12) && inputDay > (DateTime.DaysInMonth(2025, inputMonth) + 1))
            {
                Console.WriteLine("The date you picked is not a real date. There are less days in this month!");
                Console.WriteLine("Please try again!");
                Console.WriteLine();
                correctMonthGuess = false;
                correctDayGuess = false;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1-12");
                Console.WriteLine();
                correctMonthGuess = false;
            }
        }
    }
    else
    {
        Console.WriteLine("Please enter a number between 1-31");
        Console.WriteLine();
        correctDayGuess = false;
    }
}
while (correctDayGuess == false || correctMonthGuess == false);

Console.ReadLine();





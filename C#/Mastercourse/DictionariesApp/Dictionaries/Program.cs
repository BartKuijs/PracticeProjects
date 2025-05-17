

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is: {lookup["fish"]}");



Dictionary<int, string> employees = new Dictionary<int, string>();

employees[33] = "Bart Kuijs";
employees[28] = "Sue Storm";
employees[95] = "Tim Corey";

Console.WriteLine($"The employee with the ID number 28 is: {employees[28]}");


Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;
dayOfWeek["Saturday"] = 7;
dayOfWeek["Sunday"] = 1;

Console.WriteLine(dayOfWeek["Wednesday"]);



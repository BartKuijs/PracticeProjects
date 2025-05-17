

List<string> classRoster = new List<string>();

bool isValid = true;

do
{
    Console.Write("Would you like to add more students to the class roster? y/n ");
    string answer = Console.ReadLine();
    if (answer != "" && answer.ToLower()[0] == 'y')
    {
        // Ask for the input that would be added to the list.
        Console.Write("Please enter a name: ");
        string input = Console.ReadLine();
        if(input != "")
        {
            classRoster.Add(input);
        }
        else
        {
            Console.WriteLine("Please enter a valid name.");
        }
    }
    else
    {
        isValid = false;
    }

} while (isValid);

Console.WriteLine($"There are {classRoster.Count} student(s) in the class roster.");



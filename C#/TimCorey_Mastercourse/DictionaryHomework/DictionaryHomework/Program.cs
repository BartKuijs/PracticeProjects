

Dictionary<string, string> employees = new Dictionary<string, string>();

employees["one"] = "Tim Corey";
employees["two"] = "Bart Kuijs";
employees["three"] = "Bob Smith";
employees["four"] = "Jane Doe";
bool isValid = true;

do
{
    Console.Write("What is your ID? ");
    string id = Console.ReadLine();

    



    if (id != "" && employees.ContainsKey(id.ToLower()))
    {
        Console.WriteLine($"Your name is: {employees[id.ToLower()]}.");
        isValid = false;
    }
    else
    {
        Console.WriteLine("Your ID is not in the Dictionary.");
    }

} while (isValid);

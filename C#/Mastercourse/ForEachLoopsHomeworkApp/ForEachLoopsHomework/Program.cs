

List<string> firstNames = new List<string>();

bool isValid = true;

do
{
    Console.Write("Please enter a first name: ");
    string answer = Console.ReadLine();
    if (answer != "")
    {
        firstNames.Add(answer);
    }
    
    Console.Write("Would you like to add another name? y/n ");
    string continueNames = Console.ReadLine();
    if(continueNames != "" && (continueNames[0] == 'y' || continueNames[0] == 'Y'))
    {

    }
    else
    {
        isValid &= false;
    }

}
while (isValid);

foreach(string firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}");
}

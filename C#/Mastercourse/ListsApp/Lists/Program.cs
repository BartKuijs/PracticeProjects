

List<string> firstNames = new List<string>();
firstNames.Add("Bart");
firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");

int x = 0;

while(x < firstNames.Count)
{
    Console.WriteLine(firstNames[x]);
    x++;
}

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);


// List<T> - generic


string data = "Corey,Smith,Jones";

List<string> lastNames = data.Split( ',' ).ToList();
lastNames.Add("Franklin");

int y = 0;
while(y < lastNames.Count)
{
    Console.WriteLine(lastNames[y]);
    y++;
}


List<string> test = new List<string>();
do
{
    Console.Write("Please write something that you would like to add to the list. ");
    string input = Console.ReadLine();
    if (test.Contains(input))
    {
        Console.WriteLine("This item is already in the list. Please add something else");
    }
    else
    {
        test.Add(input);
    }
    
} while (test.Count < 5);

Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);
Console.WriteLine(test[3]);
Console.WriteLine(test[4]);


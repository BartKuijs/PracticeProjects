

Dictionary<string, string> names = new Dictionary<string, string>();

Console.Write("Please ennter the dictionary Key. ");
string key = Console.ReadLine();
Console.Write("Please enter the dictionary Value. ");
string value = Console.ReadLine();

if(key != "" && value != "" &&!(names.ContainsKey(key)))
{
    names.Add(key, value);
    Console.WriteLine(names[key]);
    Console.WriteLine(names.Count() + 1);
}





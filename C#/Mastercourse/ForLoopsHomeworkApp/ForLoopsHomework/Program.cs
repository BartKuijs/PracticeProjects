

using System.Linq;

Console.Write("Please enter a comma-separated list of first names (no spaces). ");
string names = Console.ReadLine();

names = names.Replace(", ", ",");



string[] namesArray = new string[names.Split(',').Count()];
namesArray = names.Split(',').ToArray();

for (int i = 0; i < namesArray.Length; i++)
{
    
    Console.WriteLine($"Hello {namesArray[i]}");
}





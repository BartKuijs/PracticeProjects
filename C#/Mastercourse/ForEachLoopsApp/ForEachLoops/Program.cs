

string data = "Tim,Sue,Bob,Jane";

List<string> firstnames = data.Split(',').ToList();

foreach (string firstName in firstnames)
{
    Console.WriteLine($"Hello {firstName}");
}





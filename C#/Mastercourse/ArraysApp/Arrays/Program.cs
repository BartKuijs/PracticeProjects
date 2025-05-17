
// 0-based counting - 0,1,2,3,4
// 1-based counting - 1,2,3,4,5


using System.Security.AccessControl;

//string[] firstNames = new string[5];
//firstNames[0] = "Bart";
//firstNames[1] = "Tim";
//firstNames[2] = "Bob";
//firstNames[4] = "Sue";


//Console.WriteLine($"the firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]} and {firstNames[4]}.");

//firstNames[0] = "Bartolomeus";

//Console.WriteLine(firstNames[0]);


int x = 0;
string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

while (x < firstNames.Length)
{
    Console.WriteLine(firstNames[x]);
    x++;
}

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] {2,3,4};


//foreach (string name in firstNames) 
//{ 
//    Console.WriteLine(firstNames[x]);
//    x++;
//}

//Console.WriteLine(firstNames.Length);



string result = SomethingSomething(1234);
Console.WriteLine(result);



static string SomethingSomething<T>(T input)
{
    string output = input.ToString();

    return output;
}



using MiniProjectDebugging;



try
{
	double i = DebuggingMethods.W(0.22);
    Console.WriteLine(i);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine("something went wrong.");
}

Console.WriteLine("The solution should be the same:");

try
{
    Console.WriteLine(DebuggingMethods.Solution(0.22));
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine("something went wrong.");
}


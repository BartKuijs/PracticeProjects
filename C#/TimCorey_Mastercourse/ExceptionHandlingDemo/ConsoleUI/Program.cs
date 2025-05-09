

using ConsoleUI;

try
{
	BadCall.BadCalls();
}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);
    Console.WriteLine(DateTime.Now);

}




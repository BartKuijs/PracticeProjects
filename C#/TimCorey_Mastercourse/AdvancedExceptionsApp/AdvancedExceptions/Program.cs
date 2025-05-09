

using AdvancedExceptions;
string name = "";
try
{

    SampleMethods.DifferentMethod();
    Console.Write("What is your name? ");
    name = Console.ReadLine();
    SampleMethods.ComplexMethod(name);
	SampleMethods.SimpleMethod();
    
}
catch(InvalidOperationException ex)
{
    Console.WriteLine("Hi");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finish your code");
}
catch (Exception ex) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used Tim's name, didn't you?");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("I always run");
}

Console.WriteLine("will this run?");



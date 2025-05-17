

List<IRun> running = new List<IRun> ();

Person person = new Person ();
Animal animal = new Animal ();
Animal animal2 = new Animal();
running.Add (animal);
running.Add (person);
running.Add (animal2);

foreach(var run in running)
{
    run.Run();
}

public class Person : IRun
{
    public void Run()
    {
        Console.WriteLine("This is a person that is running");
    }
}

public class Animal : IRun
{
    public void Run()
    {
        Console.WriteLine("This is an animal that is running");
    }
}

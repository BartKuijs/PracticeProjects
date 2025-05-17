

Person person = new Person
{
    FirstName = "Bart",
    LastName = "Kuijs"
};

Console.WriteLine(person);


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}

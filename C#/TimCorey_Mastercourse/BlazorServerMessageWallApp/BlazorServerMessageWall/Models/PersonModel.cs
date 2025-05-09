namespace BlazorServerMessageWall.Models;

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Message => $"Hello {FirstName} {LastName}";
}


var person = new PersonModel();
person.FirstName = "Bart";
person.LastName = "Kuijs";

person.GenerateEmail();

Console.WriteLine(person.Email);


public class EmployeeModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public EmployeeModel()
    {
        FirstName = "Bart";
        LastName = "Kuijs";
    }
    public EmployeeModel(string FirstName)
    {
        FirstName = FirstName;
    }
    public EmployeeModel(string FirstName, string LastName)
    {
        FirstName = FirstName;
        LastName = LastName;
    }
}


public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public PersonModel()
    {
        
    }

    public PersonModel(string FirstName, string LastName)
    {
        FirstName = FirstName;
        LastName = LastName;
    }

    public PersonModel(string FirstName, string LastName, string Email)
    {
        FirstName = FirstName;
        LastName = LastName;
        Email = Email;
    }

    public void GenerateEmail()
    {
        GenerateEmail("gmail.com", false);
    }

    public void GenerateEmail(string domain)
    {
        GenerateEmail(domain, false);
    }

    public void GenerateEmail(bool firstInitialMethod)
    {
        GenerateEmail("gmail.com", firstInitialMethod);
    }

    public void GenerateEmail(string domain, bool firstInitialMethod)
    {
        if (firstInitialMethod == true)
        {
            Email = $"{FirstName.ToLower()[0]}.{LastName.ToLower()}@{domain}";
        }
        else
        {
            Email = $"{FirstName.ToLower()}.{LastName.ToLower()}@{domain}";
        }
    }
}
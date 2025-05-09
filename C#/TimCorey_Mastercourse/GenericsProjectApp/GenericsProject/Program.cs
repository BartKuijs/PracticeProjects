


//string[] testArray;



//List<string> strings = new List<string>();
//List<int> ints = new List<int>();

//strings.Add("Hi");
//ints.Add(1);


//string result = FizzBuzz(123456789123456);

//Console.WriteLine(result);

//result = FizzBuzz(new PersonModell { FirstName = "Tim", LastName = "Corey"});

//Console.WriteLine(result);


GenericHelper<PersonModell> peopleHelper = new GenericHelper<PersonModell>();
peopleHelper.CheckItemAndAdd(new PersonModell { FirstName = "Tim", HasError = true });

foreach(var item in peopleHelper.RejectedItems)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
}

static string FizzBuzz<T>(T item)
{
    int itemLength = item.ToString().Length;
    string output = "";

    if (itemLength % 3 == 0)
    {
        output += "Fizz";
    }
    if (itemLength % 5 == 0)
    {
        output += "Buzz";
    }

    return output;
    // 3 - Fizz, 5 - Buzz, 3 & 5 - FizzBuzz
}

public class GenericHelper<T> where T: IErrorCheck
{
    public List<T> Items { get; set; } = new List<T>();
    public List<T> RejectedItems { get; set; } = new List<T>();
  

    public void CheckItemAndAdd(T item)
    {
        if(item.HasError == false)
        {
            Items.Add(item);
        }
        else
        {
            RejectedItems.Add(item);
        }
        
    }
}

public interface IErrorCheck
{
    bool HasError { get; set; }
}

public class CarModel : IErrorCheck
{
    public string Manufacturer { get; set; }
    public int YearManufactured { get; set; }
    public bool HasError { get; set; }
}

public class PersonModell : IErrorCheck
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool HasError { get; set; }
}



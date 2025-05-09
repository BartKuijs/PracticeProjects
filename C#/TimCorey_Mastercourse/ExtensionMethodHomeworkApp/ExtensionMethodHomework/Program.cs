

PersonModel person = new PersonModel();


person.FirstName = "What is your first name? ".RequestString();
person.LastName = "What is your last name? ".RequestString();
person.Age = "What is your age? ".RequestInt(0,120);

Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");






public static class ConssoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";

        while(string.IsNullOrEmpty(output))
        {
            Console.Write(message); 
            output = Console.ReadLine();
        }

        return output;
    }

    private static int RequestInt(this string message, bool useMinMax, int MinValue, int MaxValue)
    {
        int output = 0;
        bool isValidNumber = false;
        bool isInValidRange = true;
        

        while (isValidNumber == false || isInValidRange == false)
        {
            Console.Write(message);
            isValidNumber = int.TryParse(Console.ReadLine(), out output);

            if(useMinMax == true)
            {
                isInValidRange = (output >= MinValue && output <= MaxValue);
            }
        }

        return output;
    }

    public static int RequestInt(this string message, int MinValue, int MaxValue)
    {

        int output = message.RequestInt(true, MinValue, MaxValue);
        return output;
    }

    public static int RequestInt(this string message)
    {
        int output = message.RequestInt(false, 0,0);
        return output;
    }
}


public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int NumberOfChildren { get; set; }
}



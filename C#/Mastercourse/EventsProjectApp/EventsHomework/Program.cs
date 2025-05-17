using System.Threading.Channels;



StudentApplications math = new StudentApplications("Calculus 205", 2);
StudentApplications english = new StudentApplications("English 101", 5);

math.NoApplicationsAvailable += CollegeClass_NoApplicationsAvailable;

void CollegeClass_NoApplicationsAvailable(object? sender, string e)
{
    StudentApplications model = (StudentApplications)sender;
    Console.WriteLine();
    Console.WriteLine($"{model.ClassTitle}: Full");
    Console.WriteLine();
}

Console.WriteLine(math.SignUpStudent("Bart Kuijs"));
Console.WriteLine(math.SignUpStudent("James Donald"));
Console.WriteLine(math.SignUpStudent("Harry Potter"));



public class StudentApplications
{
    public event EventHandler<string> NoApplicationsAvailable;

    private List<string> students = new List<string>();
    private List<string> canceledApplications = new List<string>();

    public string ClassTitle { get; set; }
    public int MaxApplicationLimit { get; set; }

    public StudentApplications(string course, int max)
    {
        ClassTitle = course;
        MaxApplicationLimit = max;        
    }

    public string SignUpStudent(string student)
    {
        string output;
        if(students.Count < MaxApplicationLimit)
        {
            students.Add(student);
            output = $"{student} has been applied to {ClassTitle}";

        }
        else if(students.Count == MaxApplicationLimit && canceledApplications.Count == 0)
        {
            NoApplicationsAvailable?.Invoke(this, $"{ClassTitle} has reached the maximum applications.");
            canceledApplications.Add(student);
            output = $"{student}'s application has been canceled.";
        }
        else
        {
            canceledApplications.Add(student);
            output = $"{student}'s application has been canceled.";
        }
        return output;
    }

}

//public static class ConsoleHelpers
//{
//    public static void PrintToConsole(this string message)
//    {

//        Console.WriteLine(message);

//    }
//}



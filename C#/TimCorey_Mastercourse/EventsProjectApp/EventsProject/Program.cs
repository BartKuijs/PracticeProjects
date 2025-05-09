



CollegeClassModel history = new CollegeClassModel("History 101", 3);
CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

history.EnrollementFull += CollegeClass_EnrollementFull;

math.EnrollementFull += CollegeClass_EnrollementFull;

history.SignUpStudent("Tim Corey").PrintToConsole();
history.SignUpStudent("Sue Storm").PrintToConsole();
history.SignUpStudent("Mary Jones").PrintToConsole();
history.SignUpStudent("John Doe").PrintToConsole();
history.SignUpStudent("Sandy Patty").PrintToConsole();
Console.WriteLine();



math.SignUpStudent("Mary Jones").PrintToConsole();
math.SignUpStudent("John Doe").PrintToConsole();
math.SignUpStudent("Sandy Patty").PrintToConsole();

static void CollegeClass_EnrollementFull(object? sender, string e)
{
    CollegeClassModel model = (CollegeClassModel)sender;

    Console.WriteLine();
    Console.WriteLine($"{model.CourseTitle}: Full");
    Console.WriteLine();
}
public static class ConsoleHelpers
{
    public static void PrintToConsole(this string message)
    {
        
        Console.WriteLine(message);
        
    }
}

public class CollegeClassModel
{
    public event EventHandler<string> EnrollementFull;

    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingList = new List<string>();

    public string CourseTitle { get; private set; }
    public int MaximumStudents { get; private set; }
    public CollegeClassModel(string title, int maximumStudents)
    {
        CourseTitle = title;
        MaximumStudents = maximumStudents;
    }

    public string SignUpStudent(string student)
    {
        string output;
        if(enrolledStudents.Count < MaximumStudents)
        {
            enrolledStudents.Add(student);
            output = $"{student} was enrolled in {CourseTitle}.";
            
        }
        else if (enrolledStudents.Count == MaximumStudents && waitingList.Count == 0)
        {
            // check to see if we are maxed out
            EnrollementFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
            waitingList.Add(student);
            output = $"{student} was added to the wait list in {CourseTitle}.";
        }
        else
        {
            waitingList.Add(student);
            output = $"{student} was added to the wait list in {CourseTitle}.";
        }
        return output ;
    }

}


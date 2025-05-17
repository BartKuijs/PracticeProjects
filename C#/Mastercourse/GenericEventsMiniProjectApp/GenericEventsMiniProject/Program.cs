


List<PersonModel> people = new List<PersonModel>
{
    new PersonModel{FirstName = "Bart", LastName = "Kuijs", Email = "bartkuijs@live.nl" },
    new PersonModel{FirstName = "Tim", LastName = "Coreydarnit", Email = "tim@iamtimcorey.com" },
    new PersonModel{FirstName = "Sue", LastName = "Storm", Email = "sue@stormy.net" },
    new PersonModel{FirstName = "John", LastName = "Smith", Email = "john4darn5376@aol.com" }
};

List<CarModel> cars = new List<CarModel>
{
    new CarModel{Manufacturer = "Theckoyota", Model = "Corolla"},
    new CarModel{Manufacturer = "Toyota", Model = "HighLander"},
    new CarModel{Manufacturer = "Ford", Model = "Mustang"}

};
DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();

peopleData.BadEntryFound += PeopleData_BadEntryFound;

void PeopleData_BadEntryFound(object? sender, PersonModel e)
{
    Console.WriteLine($"Bad entry found for {e.FirstName} {e.LastName} {e.Email}");
}

peopleData.SaveToCSV(people, @"C:\Users\people.csv");


DataAccess<CarModel> carData = new DataAccess<CarModel>();

carData.BadEntryFound += CarData_BadEntryFound;

void CarData_BadEntryFound(object? sender, CarModel e)
{
    Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
}

carData.SaveToCSV(cars, @"C:\Users\cars.csv");

public class DataAccess<T> where T: new()
{
    public event EventHandler<T> BadEntryFound;
    public void SaveToCSV(List<T> items, string filePath) 
    {
        List<string> rows = new List<string>();
        T entry = new T();
        var cols = entry.GetType().GetProperties();
        string row = "";
        foreach(var col in cols)
        {
            row += $",{col.Name}";
        }
        row = row.Substring(1); // FirstName,LastName,Email

        rows.Add(row);

        foreach(var item in items)
        {
            row = "";
            bool badWordDetected = false;
            foreach (var col in cols)
            {
                string val = col.GetValue(item, null).ToString();
                badWordDetected = BadWordDetector(val);
                if(badWordDetected == true)
                {
                    BadEntryFound?.Invoke(this, item);
                    break;
                }

                row += $",{val}";
            }
            if(badWordDetected == false)
            {
                row = row.Substring(1); // FirstName,LastName,Email

                rows.Add(row);
            }
            

            
        }

        File.WriteAllLines(filePath, rows);
    }

    private bool BadWordDetector(string stringToTest)
    {
        bool output = false;
        string lowerCaseTest = stringToTest.ToLower();
        if(lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
        {
            output = true;
        }

        return output;
    }
}


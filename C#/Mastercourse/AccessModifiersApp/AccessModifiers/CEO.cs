

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

using DemoLibrary;

public class CEO : Manager
{
    public void GetConnectionInfo()
    {
        ModifiedDataAccess data = new ModifiedDataAccess();
        data.GetUnsecureConnectionInfo();
        // formerLastName = "test";
    }
}


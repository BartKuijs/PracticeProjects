

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

using DemoLibrary;

public class ModifiedDataAccess : DataAccess
{
    public void GetUnsecureConnectionInfo()
    {
        GetConnectionString();
    }
}


namespace DemoLibrary;

public class DataAccess
{
    // internal: anything within the same assembly can access it
    // protected internal can be accessed within the same assembly and by childclasses
    protected internal string GetConnectionString()
    {
        return "Sensitive Data";
    }
}

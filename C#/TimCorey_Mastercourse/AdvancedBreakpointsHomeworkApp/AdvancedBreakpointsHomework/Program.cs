

int a = 0;
for(int i = 1; i <= 100; i++)
{
    try
    {
        if (i == 73)
        {
            throw new Exception("This is an exception");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);

    }
}



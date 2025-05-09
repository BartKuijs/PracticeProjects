

int[] ints = new int[] {1,2,3,4,5};

for(int i = 0; i <= ints.Length; i++)
{

	try
	{
		Console.WriteLine(ints[i]);
	}
	catch (Exception ex)
	{
        Console.WriteLine("There has been an error.");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(ex);
	}
}



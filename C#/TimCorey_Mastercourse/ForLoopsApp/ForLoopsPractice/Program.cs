

List<int> soldItems = new();

soldItems.Add(5);
soldItems.Add(10);
soldItems.Add(20);

int totalSoldItems = 0;
int gold = 0;


for (int i = 0; i < soldItems.Count; i++)
{
    totalSoldItems += soldItems[i];
    Console.WriteLine($"You have sold {soldItems[i]} items.");
    if (soldItems[i] < 10)
    {
        gold += soldItems[i] * 10;
    }
    else if (soldItems[i] < 20)
    {
        gold += soldItems[i] * 9;
    }
    else
    {
        gold += soldItems[i] * 8;
    }
    
}



Console.WriteLine();
Console.WriteLine($"Your total amount of items sold is: {totalSoldItems}");
Console.WriteLine(gold);


List<IAttackItems> attackItems = new List<IAttackItems>();  
List<IDefenceItems> defenceItems = new List<IDefenceItems>();
List<ISupportItems> supportItems = new List<ISupportItems>();

Swords sword = new Swords { LengthOfSword = 12, AttackStat = 24};
Shields shield = new Shields { DefenceStat = 20, HasMagic = true, SupportType = "Healing", IsRound = true };
Rings ring = new Rings { SupportType = "Extra Gold", HasMagic = true, BrokenMagic = true};

attackItems.Add(sword);
defenceItems.Add(shield);
supportItems.Add(ring);
supportItems.Add(shield);

foreach(var supportItem in supportItems)
{
    if( supportItem.SupportType == "Healing")
    {
        Console.WriteLine(supportItem.HasMagic);
        Console.WriteLine(supportItem.SupportType);
    }
    else
    {
        Console.WriteLine(supportItem.SupportType);
    }
    
}




public class InventoryItems
{
    public string ItemName { get; set; }
}

public interface IAttackItems
{
    public int AttackStat { get; set; }
}

public interface IDefenceItems
{
    public int DefenceStat { get; set; }
}

public interface ISupportItems
{
    public string SupportType { get; set; }
    public bool HasMagic { get; set; }
}

public class Swords : IAttackItems

{
    public int LengthOfSword { get; set; }
    public int AttackStat { get ; set ; }
}

public class Shields : IDefenceItems, ISupportItems
{
    public bool IsRound { get; set; }
    public int DefenceStat { get; set; }
    public string SupportType { get; set; }
    public bool HasMagic { get; set; }
}

public class Rings : ISupportItems
{
    public bool BrokenMagic { get; set; }
    public string SupportType { get; set; }
    public bool HasMagic { get; set; }
}
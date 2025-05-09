

bool hasKey = false;
bool doorOpen = false;

Console.Write("You are locked in a room. What would you do to escape? look/sit ");
string? answer = Console.ReadLine();

if(answer.ToLower() == "look")
{
    Console.WriteLine("You look around the room and see a key. \nYou pick up the key.");
    hasKey = true;
    Console.WriteLine();
    Console.Write("You are locked in a room. You have a key now. Would you like to try the key? yes/no ");
    string? answer2 = Console.ReadLine();
    if (answer2.Length > 0 && (answer2[0] == 'y' || answer2[0] == 'Y'))
    {
        doorOpen = true;
        Console.WriteLine();
        Console.WriteLine("You open the door and are free. \n \nYou have won the game!!!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("You have lost the game... You died!");
    }
}
else if(answer.ToLower() == "sit")
{
    Console.WriteLine("You sit and wait but nothing happens.");
    Console.WriteLine("You have lost the game... You died!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("So you do not wish to play this game... You died!");
}





using MiniGameProject;

UserMessages.WelcomeMessage();
string name = GetData.GetStringFromUser("Please enter your name: ");
string typeFire = "fire";
string typeWater = "water";



string typeOfSpells = CheckMethods.WhichTypeOfSpells(typeFire, typeWater);

Console.WriteLine($"Thank you {name}. You have chosen type: {typeOfSpells}");

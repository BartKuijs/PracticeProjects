using System.Runtime.CompilerServices;

HotelRoomModel room = new HotelRoomModel();

//room.TurnOnAir().SetTemperature(72).OpenShades();

Person person = new Person();

person.SetDefaultAge().PrintInfo();

//room.TurnOffAir().CloseShades();




public class Person
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        FirstName = "Bart";
        LastName = "Kuijs";
    }

}

public static class ExtensionPerson
{
    public static void PrintInfo(this Person person)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");

    }

    public static Person SetDefaultAge(this Person person)
    {
        person.Age = 33;
        return person;
    }
}

public class HotelRoomModel
{
    public int Temperature { get; set; }
    public bool IsAirRunning { get; set; }
    public bool AreShadesOpen { get; set; }

}

public static class ExtensionSamples
{
    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }

    public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.IsAirRunning = true;
        return room;
    }
    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.IsAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = true;
        return room;
    }
    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = false;
        return room;
    }

}



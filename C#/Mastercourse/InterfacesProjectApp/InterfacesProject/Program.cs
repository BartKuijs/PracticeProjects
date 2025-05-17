

// Interface is a contract
// Classes implement interfaces

List<IComputerController> controllers = new List<IComputerController>();
Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();
BatteryPoweredGameController battery = new BatteryPoweredGameController();
BatteryPoweredKeyboard batteryPoweredKeyboard = new BatteryPoweredKeyboard();
controllers.Add(keyboard);
controllers.Add(gameController);
controllers.Add(battery);


foreach(IComputerController controller in controllers)
{
   if(controller is GameController gc)
    {
        gc.Dispose();
    }
   if(controller is IBatteryPowered powered)
    {
        powered.BatteryLevel = battery.BatteryLevel;
        controller.Dispose();
    }
}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();

powereds.Add(battery);
powereds.Add(batteryPoweredKeyboard);

using (GameController gc = new GameController())
{

}

public interface IComputerController : IDisposable
{
    void Connect();

    void CurrentKeyPressed();
}
public class Keyboard : IComputerController
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        
    }

    public string ConnectionType { get; set; }
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get ; set ; }
}

public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        // do whatever shutdown tasks needed
    }

    
}

public class BatteryPoweredGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}


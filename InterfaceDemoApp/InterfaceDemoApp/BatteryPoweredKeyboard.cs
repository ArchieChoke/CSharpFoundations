namespace InterfaceDemoApp
{
    public class BatteryPoweredKeyboard : GameController, IBatteryPowered
    {

        public int BatteryLevel { get; set; }
    }

}

using System;

namespace InterfaceDemoApp
{
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
            Console.WriteLine("The Controller is connected");
        }

        public void CurrentKeyPressed()
        {
            Console.WriteLine("The Controller key is pressed");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing of Keyboard");
        }

    }

}

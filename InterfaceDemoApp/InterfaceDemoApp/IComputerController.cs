using System;

namespace InterfaceDemoApp
{
    public interface IComputerController : IDisposable
    {
        void Connect();

        void CurrentKeyPressed();

    }

}

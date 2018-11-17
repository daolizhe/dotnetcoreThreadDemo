using System;
using System.Threading;
namespace dotnetcoreThreadInterrupt
{
    class Application
    {
        public void Start()
        {
            Thread thread = new Thread(TtoRun);
            thread.IsBackground=true;
            thread.Start();
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(1000);
            }
            thread.Interrupt();
        }
        public void TtoRun()
        {
            while (true)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("W");
            }
        }
    }
}

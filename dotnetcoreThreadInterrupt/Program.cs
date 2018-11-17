using System;
using System.Threading;

namespace dotnetcoreThreadInterrupt
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Start();
        }
    }
}

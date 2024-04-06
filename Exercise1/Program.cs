using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            FuelTank tank = new FuelTank(300);
            tank.fill(100);
            Console.WriteLine("Level: " + tank.GetLevel());

            Engine eng = new Engine();
            eng.start();
            Thread.Sleep( 2000 );
            eng.stop();
            Console.ReadLine();
        }
    }
}

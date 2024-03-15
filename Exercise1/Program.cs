using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Engine eng = new Engine();
            eng.start();
            Thread.Sleep( 2000 );
            eng.stop();
            Console.ReadLine();
        }
    }
}

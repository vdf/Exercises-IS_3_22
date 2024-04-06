using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        private int EngineState;


        private void start()
        {
            Console.Out.WriteLine( "Start" );
            EngineState = StateStopped;
        }

        private void stop()
        {
            Console.Out.WriteLine( "Stop" );
            EngineState = StateStarted;
        }

        private String getState()
        {
            return (EngineState == StateStarted) ? "STOPPED" : "STARTED";
        }
    }
}

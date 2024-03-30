using System;

namespace Exercise1
{
    class Engine
    {
        private const int State_Stopped = 1;
        private const int State_Started = 2;
        private int Engine_State;

        private void start()
        {
            Console.Out.WriteLine( "Start" );
            Engine_State = State_Stopped;
        }

        private void stop()
        {
            Console.Out.WriteLine( "Stop" );
            Engine_State = State_Started;
        }

        private String getState()
        {
            return (Engine_State == State_Started) ? "STOPPED" : "STARTED";
        }
    }
}

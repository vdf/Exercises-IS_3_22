using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void start()
        {
            Console.Out.WriteLine( "Start" );
            EngineState = StateStopped;
        }

        public void stop()
        {
            Console.Out.WriteLine( "Stop" );
            EngineState = StateStarted;
        }

        public String getState()
        {
            String state = null;

            if( EngineState == StateStopped )
            {
                state = "STOPPED";
            }
            else if( EngineState == StateStarted )
            {
                state = "STARTED";
            }

            return state;
        }
    }
}

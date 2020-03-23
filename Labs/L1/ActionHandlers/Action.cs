using System;
using System.Threading;

namespace L1
{

    // https://www.youtube.com/watch?v=jQgwEsJISy0
    class Action
    {


        // 1. Declare a delegate
        public delegate void ActionTriggeredEventHandler(object source, EventArgs e);
        // 2. Define the event
        public event ActionTriggeredEventHandler ActionTriggered;

        public void Trigger()
        {
            Console.WriteLine("[AH] Event Log Triggered (wait 3s)...{0:F}", DateTime.Now);
            Thread.Sleep(3000);

            // 3#
            OnActionTriggered();
        }

        // 3. Raise the event
        protected virtual void OnActionTriggered()
        {
            // Ff there are any subscribers available
            if (ActionTriggered != null)
            {
                ActionTriggered(this, EventArgs.Empty);
            }

        }
    }
}
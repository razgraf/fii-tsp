using System;
using System.Threading;

namespace L1
{

    class Subscriber
    {

        public void OnActionTriggered(object source, EventArgs e)
        {
            Console.WriteLine("[AH] Action end broadcasted to subscriber... {0:F}", DateTime.Now);
        }

    }
}
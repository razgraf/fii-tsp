using System;
using System.Threading;

namespace L1
{
    class Program
    {

        static void Main(string[] args)
        {

            // doThreding();
            // doActions();
            doBackgroundWork();
        }


        /**
        * EVENTS
        */
        public static void doActions()
        {
            var action = new Action();
            var subscriber = new Subscriber();
            action.ActionTriggered += subscriber.OnActionTriggered; // Subscribe
            /***/
            action.Trigger(); // Trigger

        }


        /**
        * THREADINGS
        */


        public static void doThreding()
        {
            var calculator = new Calculator();
            calculator.start();
        }

        /**
       * BACKGOUND WORK
       */

        public static void doBackgroundWork()
        {
            var workers = new Workers();
            workers.start();
            Console.ReadKey();
        }


    }
}

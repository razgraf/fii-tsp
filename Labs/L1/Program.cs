using System;
using System.Threading;

namespace L1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(iterativePrimeFinder(5000));
            // Console.WriteLine(iterativePrimeFinderReverse(5000));

            doThreding();
            // doActions();
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


    }
}

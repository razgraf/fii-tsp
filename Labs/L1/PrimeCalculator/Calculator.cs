using System;
using System.Collections.Generic;
using System.Threading;

namespace L1
{

    class Calculator
    {

        List<string> Info { get; set; }
        private Object Lock = new object();
        private int Number = 12478645;

        public Calculator()
        {
            Info = new List<string> { };
        }

        public void start()
        {
            Thread t1 = new Thread(handleIterativePrimeFinder);
            Thread t2 = new Thread(handleIterativePrimeFinderReverse);
            t1.Start();
            t2.Start();
            Console.WriteLine("Started.");

            t1.Join();
            t2.Join();

            Console.WriteLine("Joined.");
            foreach (string item in Info)
            {
                Console.WriteLine(item);

            }
        }

        public void handleIterativePrimeFinder()
        {
            lock (Lock)
            {
                Info.Add($"Start fir: T1 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar natural dat = {Number}");
            }

            var result = iterativePrimeFinder(Number);

            lock (Lock)
            {
                Info.Add($"End fir: T1 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar prim determinat = {result}");
            }

        }

        public void handleIterativePrimeFinderReverse()
        {
            lock (Lock)
            {
                Info.Add($"Start fir: T2 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar natural dat = {Number}");
            }

            var result = iterativePrimeFinderReverse(Number);

            lock (Lock)
            {
                Info.Add($"End fir: T2 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar prim determinat = {result}");
            }

        }




        static int iterativePrimeFinder(int n)
        {
            n--;
            while (n > 1 && !isPrime(n)) n--;
            if (n <= 1) return -1;
            return n;
        }

        static int iterativePrimeFinderReverse(int n)
        {
            int i = 2, max = 2;
            while (i < n)
            {
                if (isPrime(i)) max = i;
                i++;
            }
            if (n <= 1) return -1;
            return max;
        }

        static bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }


    }
}
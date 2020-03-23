using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading;

namespace L1
{
    class Workers
    {
        BackgroundWorker worker1, worker2;

        private List<string> Info { get; set; }
        public static int Number = 12478645;

        private Object Lock = new object();

        public Boolean wait1 = true;
        public int answer1 = -1;
        public Boolean wait2 = true;
        public int answer2 = -1;


        public Workers()
        {
            Info = new List<string>() { };
            worker1 = new BackgroundWorker();
            worker2 = new BackgroundWorker();

            worker1.DoWork += new DoWorkEventHandler(Worker_DoWork_1);
            worker2.DoWork += Worker_DoWork_2;
            worker1.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged_1);
            worker2.ProgressChanged += Worker_ProgressChanged_2;
            worker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted_1);
            worker2.RunWorkerCompleted += Worker_RunWorkerCompleted_2;
            worker1.WorkerReportsProgress = true;
            worker2.WorkerReportsProgress = true;
        }

        public void start()
        {
            if (worker1.IsBusy != true)
                worker1.RunWorkerAsync();
            if (worker2.IsBusy != true)
                worker2.RunWorkerAsync();
        }


        private void Worker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Worker_RunWorkerCompleted_1");

            lock (Lock)
            {
                this.Info.Add($"End worker: B1 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar prim determinat = {answer1}");
            }

            if (answer1 != -1 && answer2 != -1)
            {
                foreach (string item in Info)
                {
                    Console.WriteLine(item);
                }
                System.Environment.Exit(1);
            }
            else Console.WriteLine("Waiting for Worker 2 to finish...");
        }
        private void Worker_RunWorkerCompleted_2(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Worker_RunWorkerCompleted_2");

            lock (Lock)
            {
                Info.Add($"End worker: B1 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar prim determinat = {answer1}");
            }

            if (answer1 != -1 && answer2 != -1)
            {
                foreach (string item in Info)
                {
                    Console.WriteLine(item);

                }
                System.Environment.Exit(1);
            }
            else Console.WriteLine("Waiting for Worker 1 to finish...");

        }

        private void Worker_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            // Console.WriteLine("Task 1 Progress Changed");
        }

        private void Worker_ProgressChanged_2(object sender, ProgressChangedEventArgs e)
        {
            // Console.WriteLine("Task 2 Progress Changed");
        }

        private void Worker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Worker_DoWork_1");

            lock (Lock)
            {
                Info.Add($"Start worker: B1 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar natural dat = {Workers.Number}");
            }

            int n = Workers.Number;
            n--;
            while (n > 1 && !isPrime(n))
            {
                n--;
                worker1.ReportProgress(0);
            }
            if (n <= 1) answer1 = 1;
            else answer1 = n;

        }

        private void Worker_DoWork_2(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Worker_DoWork_2");

            lock (Lock)
            {
                Info.Add($"Start worker: B2 - {DateTime.Now.ToString("hh:mm:s:ms")}. Numar natural dat = {Workers.Number}");
            }

            int n = Workers.Number;
            int i = 2, max = 2;
            while (i < n)
            {
                if (isPrime(i)) max = i;
                i++;
                worker2.ReportProgress(0);
            }
            if (n <= 1) answer2 = 1;
            else answer2 = max;

        }



        static bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }


    }
}
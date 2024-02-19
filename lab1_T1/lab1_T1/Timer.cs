using System;
using System.Threading;

namespace lab1_T1
{
    public delegate void TimerDelegate();

    public class Timer
    {
        private readonly TimerDelegate timerDelegate;
        private readonly int intervalInSeconds;
        private bool isRunning;
        private Thread timerThread;

        public Timer(TimerDelegate timerDelegate, int intervalInSeconds)
        {
            if (timerDelegate == null)
            {
                throw new ArgumentNullException(nameof(timerDelegate));
            }
            this.timerDelegate = timerDelegate;
            this.intervalInSeconds = intervalInSeconds;
            isRunning = false;
        }

        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                timerThread = new Thread(ExecuteTimer);
                timerThread.Start();
            }
            else
            {
                Console.WriteLine("Таймер вже запущений.");
            }
        }

        public void Stop()
        {
            isRunning = false;
        }

        private void ExecuteTimer()
        {
            while (isRunning)
            {
                Thread.Sleep(intervalInSeconds * 1000);
                timerDelegate();
            }
        }

    }
}
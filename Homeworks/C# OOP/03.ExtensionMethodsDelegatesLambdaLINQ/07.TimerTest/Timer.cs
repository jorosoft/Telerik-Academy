namespace _07.TimerTest
{
    using System;
    using System.Diagnostics;

    public class Timer
    {
        private int time;
        
        public Timer(int time)
        {
            this.Time = time;
        }

        private delegate void SayBeep();

        private int Time
        {
            get
            {
                return this.time;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Time can't be smaller than 0 or equal!");
                }

                this.time = value;
            }
        }

        public void InvokeDelegate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var myDelegate = new SayBeep(this.Beep);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.time)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }

        private void Beep()
        {
            Console.Beep(800, 500);
            Console.WriteLine("BeeP");
        }
    }
}

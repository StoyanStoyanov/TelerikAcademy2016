namespace Ex07Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void Delegate();

        public Timer(Delegate d, uint t)
        {
            this.Method = d;
            this.Seconds = t;

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    this.Method();
                    Thread.Sleep((int)this.Seconds);
                }
            });

            thread.Start();
        }

        public Delegate Method { get; set; }

        public uint Seconds { get; set; }
    }
}
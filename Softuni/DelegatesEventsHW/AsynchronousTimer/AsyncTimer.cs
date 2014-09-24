namespace AsynchronousTimer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsyncTimer
    {
        public Action Tick;

        private int interval;
        private int ticks;

        public AsyncTimer(Action method, int interval, int ticks)
        {
            this.Interval = interval;
            this.Ticks = ticks;
            this.Tick = method;
            this.OnTick(EventArgs.Empty);
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval", "Timer interval can not be negative!");
                }

                this.interval = value;
            }
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval", "Timer interval can not be negative!");
                }

                this.ticks = value;
            }
        }

        public virtual void OnTick(EventArgs e)
        {
            if (null != this.Tick)
            {
                Thread newThread = new Thread(() =>
                  {
                      int passedTicks = 0;
                      while (passedTicks < this.Ticks)
                      {
                          this.Tick();
                          passedTicks++;
                          Thread.Sleep(this.Interval);
                      }
                  });
                newThread.Start();
            }
        }
    }
}

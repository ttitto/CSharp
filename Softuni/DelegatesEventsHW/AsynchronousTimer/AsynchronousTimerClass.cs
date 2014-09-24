namespace AsynchronousTimer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsynchronousTimerClass
    {
        public static void Main(string[] args)
        {
            AsyncTimer at = new AsyncTimer(RespondMethod, 200, 10);
            AsyncTimer at2 = new AsyncTimer(SecondMethod, 250, 30);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main program action!");
                Thread.Sleep(100);
            }
        }

       public static void RespondMethod()
        {
            Console.WriteLine("Test Print!");
        }

       public static void SecondMethod()
       {
           Console.WriteLine("Second subscriber!");
       }
    }
}

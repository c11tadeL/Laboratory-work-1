using System;
using System.Threading;

namespace lab1_T1
{

    class Program
    {
        static void MyMethod() { Console.WriteLine("Пiу-Пау"); }
        static void MyMethod2() { Console.WriteLine("Ба-Бах"); }

        static void Main()
        {
            TimerDelegate myMethodDelegate = MyMethod;
            TimerDelegate myMethodDelegate2 = MyMethod2;

            Timer timer1 = new Timer(myMethodDelegate, 2);
            Timer timer2 = new Timer(myMethodDelegate2, 4);

            timer1.Start();
            timer2.Start();

            Thread.Sleep(5000);

            timer1.Stop();
            timer2.Stop();

        }
    }
}

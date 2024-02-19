//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace lab1_T1
//{
//    public delegate void TimerrDelegate();

//    class Class
//    {
//        static void MyMethod()
//        {
//            Console.WriteLine("Пiу-Пау");
//        }

//        static void Main()
//        {
//            TimerrDelegate myMethodDelegate = MyMethod;

//            int intervalInSeconds = 2;

//            while (true)
//            {
//                myMethodDelegate();
//                Thread.Sleep(intervalInSeconds * 1000);
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            thread user1 = new thread();

            user1.function1();
            user1.function2();

            Thread thread1 = new Thread(user1.function1);
            Thread thread2 = new Thread(user1.function2);
            thread1.Priority = ThreadPriority.Normal;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();


            Console.ReadLine();
        }
    }
}

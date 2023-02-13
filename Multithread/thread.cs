using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    internal class thread
    {
        public void function1() 
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i} - Funtion-1");
            }
        }
        public void function2() 
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i} - Funtion-2");
            }
        }
    }
}

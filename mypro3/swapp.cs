using System;
using System.Collections.Generic;
using System.Text;

namespace mypro3
{
    class swapp
    {
        static void Main(string[] args)
        {
            swap();
        }


        static void swap()
        {
            int a = 5, b = 4;
            Console.WriteLine("before swapping " + a + "b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping a=" + a + "b=" + b);
        }
    }
}

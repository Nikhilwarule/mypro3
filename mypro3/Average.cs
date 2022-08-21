using System;
using System.Collections.Generic;
using System.Text;

namespace mypro3
{
    class Average
    {
        static void Main(string[] args)
        {
            int a = 55, b = 58, c = 80, d = 89, e = 70;
            int total = 0;
            total = a + b + c + d + e;
            float avg = total / 5;
            Console.WriteLine(total );
            Console.WriteLine("avg"+avg);
        }
    }
}

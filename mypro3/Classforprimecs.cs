using System;
using System.Collections.Generic;
using System.Text;

namespace mypro3
{
    class Classforprime
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
                int a = 0;
            for (int i=1;i<=n;i++)
            {
                if (n%i==0)
                {
                    a++;
                }
            }
            if (a==2)
            {
                Console.WriteLine(+n +"num is prime" );
            }
            else
            {
                Console.WriteLine("not prime");
            }

        }
    }
    class Ce3
    {
        static void Main (string [] args )
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i=1;i<=n;i++)
            {
                if (n%i==0)
                {
                    a++;
                }
            }
            if (a==2)
            {
                Console.WriteLine(+n + "num is prime");

            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
        
}

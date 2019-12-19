using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumloop(1000));
        }
        public static int sumloop(int x)
        {
            if (x==1)
            {
                return 1;

            }
            else if (x % 2 ==1)
            {
                return x + sumloop(x - 2);
            }
            else
            {
                return sumloop(x - 1);
            }
        }
    }
}

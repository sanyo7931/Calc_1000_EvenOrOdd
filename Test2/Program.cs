using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Odd(1000));
            Console.WriteLine(Even(1000));
        }
        public static int Odd(int x)
        {
            if (x==1)
            {
                return 1;

            }
            else if (x % 2 ==1)
            {
                return x + Odd(x - 2);
            }
            else
            {
                return Odd(x - 1);
            }
        }
        public static int Even(int x)
        {
            if (x==0)
            {
                return 0;
            }
            else if (x%2==0)
            {
                return x + Even(x - 2);
            }
            else
            {
                return Even(x - 1);
            }
        }
    }
}

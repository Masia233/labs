using System;

namespace fibonacci_iteration
{
    class Program
    {
        static long Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fib(6) = " + Fib(6));
        }
    }
}

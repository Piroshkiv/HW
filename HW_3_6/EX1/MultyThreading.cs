using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_6.EX1
{
    internal class MultyThreading
    {

        public void Calc(int n)
        {

            ConcurrentDictionary<string, BigInteger> bc = new();
            bc.TryAdd("N", n);

            Thread thread1 = new Thread(() =>
            {
                bc.TryAdd( "Factarial", Factarial(n));
            });
            Thread thread2 = new Thread(() =>
            {
                bc.TryAdd("Fibanacci", Fibonacci(n));
            });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();


            bc.ToList().ForEach((e) => Console.WriteLine(e.Key + ": " + e.Value));

        }

        private BigInteger Factarial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            BigInteger res = 1;

            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }

            return res;
        }

        private BigInteger Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            BigInteger prePrevious = new BigInteger(0);
            BigInteger previous = new BigInteger(1);
            BigInteger res = 1;


            for (int i = 2; i <= n; i++)
            {
                res = prePrevious + previous;
                prePrevious = previous;
                previous = res;
            }
            return res;
        }
    }
}

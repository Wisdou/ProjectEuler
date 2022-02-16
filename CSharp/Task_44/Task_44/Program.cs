using System;
using System.Collections.Generic;

namespace Task_44
{
    class Program
    {
        static long GetMinDifference()
        {
            HashSet<long> hashset = new HashSet<long>();
            for (long i = 1; ; i++)
            {
                long numb = (i * (3 * i - 1)) / 2;
                hashset.Add(numb);
                for (long j = i - 1; j >= 1; j--)
                {
                    long sum2 = (j * (3 * j - 1)) / 2;
                    if (hashset.Contains(numb - sum2) && hashset.Contains(numb + sum2))
                    {
                        return numb - sum2;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinDifference());
        }
    }
}

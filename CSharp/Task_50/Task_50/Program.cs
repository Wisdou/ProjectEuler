using System;
using System.Collections.Generic;

namespace Task_50
{
    class Program
    {
        static bool IsPrime(int numb)
        {
            for (int i = 2; i * i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return numb > 1;
        }

        static List<int> GetNumbers(int max)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        static int GetResult(int max)
        {
            var res = GetNumbers(max);
            var hashset = new HashSet<int>(res);
            int maxInd = 0;
            int maxNumb = 0;
            int result = 0;
            int ind = 0;
            int left = 0;
            while (ind < res.Count)
            {
                maxNumb += res[ind];
                ind++;
                while (maxNumb >= max)
                {
                    maxNumb -= res[left];
                    left++;
                }
                if ((ind - left) >= maxInd)
                {
                    maxInd = (ind - left);
                    result = maxNumb;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000000));
        }
    }
}

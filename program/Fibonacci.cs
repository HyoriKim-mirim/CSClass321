using System;
using System.Collections.Generic;

namespace CSClass32
{
    internal class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public static long Get(int i)
        {
            Console.WriteLine("Get(" + i + ") 호출 -> ");
            if (i < 0) return 0;
            if (i == 1) return 1;
            if (memo.ContainsKey(i)) return memo[i];
            else
            {
                return memo[i] = Get(i - 2) + (i - 1);
            }
        }
    }
}
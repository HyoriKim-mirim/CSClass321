using System;

namespace CSClass32
{
    class Method
    {
        public double Multi(double v1, int v2)
        {
            return v1 * v2;
        }

        /// <summary>
        /// min부터 max까지 합
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최대값</param>
        /// <returns>min부터 max까지 합계</returns>
        public int Sum(int min, int max)
        {
            int output = 0;
            for(int i=min; i<=max; i++)
            {
                output += i;
            }
            return output;
        }

        /// <summary>
        /// min부터 max까지 곱
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>min부터 max까지 곱한 값</returns>
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
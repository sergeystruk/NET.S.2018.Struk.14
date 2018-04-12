using System;

namespace FibonacciSequence
{
    /// <summary>
    /// Static class with one public method to find Fibonacci Sequence
    /// </summary>
    public static class FibonacciFinder
    {
        /// <summary>
        /// Gets Fibonacci sequence to the nth element
        /// </summary>
        /// <param name="n">
        /// Number of element
        /// </param>
        /// <returns>
        /// Array of longs with Fibonacci sequence
        /// </returns>
        public static long[] GetNthFobpnacci(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (n == 1)
            {
                return new long[] {0};
            }

            long[] result = new long[n];

            result[0] = 0;
            result[1] = 1;

            checked
            {
                for (int i = 2; i < n; i++)
                {
                    result[i] = result[i - 1] + result[i - 2];
                }
            }
            
            return result;
        }
    }
}

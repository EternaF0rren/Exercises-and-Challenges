using global::System;
using global::System.Collections.Generic;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;

namespace ProjectEulerExercises
{ 
    class Exe_1_50
    {
        static void Main()
        {
            #region 1. Multiples of 3 and 5
            // Find the sum of all the multiples of 3 and 5 below 1000.

            int sum = 0;

            for (int i = 3; i < 1000; i++)           // [3, 999]
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();

            #endregion

        }
    }
}
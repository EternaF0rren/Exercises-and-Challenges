using global::System;
using global::System.Collections.Generic;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace ProjectEulerExercises
{ 
    class Exe_1_50
    {
        static void Main()
        {
            #region 1. Multiples of 3 and 5
            // Find the sum of all the multiples of 3 and 5 below 1000.

            //int sum = 0;

            //for (int i = 3; i < 1000; i++)           // [3, 999]
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion

            #region 2. Even Fibonacci Numbers
            // By considering the terms in the Fibonacci sequence whose values do not exceed four million,
            // find the sum of the even-valued terms.

            //int sum = 0;
            //int n = 1;
            //int container;
            //int i = 1;

            //while (i <= 4_000_000)
            //{
            //    // Console.WriteLine(i);        // Printing each element of the sequence

            //    if (i%2 == 0) sum += i;

            //    container = i;
            //    i += n;
            //    n = container;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion

            #region 3. Largest Prime Factor

            //long number = 600851475143;
            //long denominator;
            //int box;
            //long sum = 1;

            //for (long i = 1; i < number; i++)
            //{
            //    denominator = i;
            //    box = 0;

            //    if (box < 3)
            //    {
            //        for (long j = 1; j <= i; j++)
            //        {
            //            if (denominator % j == 0) box++;
            //        }
            //    }
            //    else break;
                
            //    if (box == 2 && (number % denominator == 0))
            //    {
            //        sum *= denominator;
            //        if (sum == number)  Console.WriteLine(denominator);
            //    }
            //}
            #endregion

        }
    }
}
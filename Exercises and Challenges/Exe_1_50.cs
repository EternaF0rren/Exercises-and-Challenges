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

            #region 4. Largest Palindrome Product
            // Find the largest palindrome made from the product of two 3-digit numbers.

            //int container = 0;

            //for (int i = 999; i != 100; i--)
            //{
            //    for (int j = 999; j != 100; j--)
            //    {
            //        int number = i * j;                   

            //        if (((number - (number % 100000))/100000 == number % 10) 
            //           && (((number % 100000) - (number % 10000))/10000 == ((number % 100) - (number % 10))/10) 
            //           && (((number % 10000) - (number % 1000))/1000 == ((number % 1000) - (number % 100))/100))
            //        {
            //            if (number > container) container = number;
            //        }
            //    }
            //}
            //Console.WriteLine(container);

            #endregion

            #region 5. Smallest Multiple
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            //int i = 0;
            //int lenght = 20;
            //int[] array = new int[lenght];
            //int counter;
            //bool flag = true;

            //for (int a = 0; a < array.Length; a++)
            //{
            //    array[a] = a + 1;
            //}

            //while (flag)
            //{
            //    i++;
            //    counter = 0;
            //    for(int a = lenght; a > 0; a--)
            //    {
            //        if (i % array[a - 1] == 0) counter++;
            //        else break;

            //        if (counter == lenght)
            //        {
            //            Console.WriteLine(i);
            //            flag = false;
            //        }
            //    }
            //}
            #endregion

            #region 6. Sum Square Difference
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            //int[] array = new int[100];
            //int sumSq = 0;
            //long sqSum = 0;

            //for (int a = 0; a < array.Length; a++)
            //{
            //    array[a] = a + 1;
            //    sumSq += array[a]* array[a];
            //    sqSum = sqSum + (a+1);
            //}

            //Console.WriteLine(sqSum * sqSum - sumSq);
            #endregion
        }
    }
}
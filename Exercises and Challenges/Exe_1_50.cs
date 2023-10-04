using global::System;
using global::System.Collections.Generic;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectEulerExercises
{ 
    class Exe_1_50
    {
        static void Main()
        {
            #region 1. Multiples of 3 and 5
            //Find the sum of all the multiples of 3 and 5 below 1000.

            //int sum = 0;

            //for (int i = 3; i < 1000; i++)          // [3, 999]
            //{
            //    if (i % 3 == 0 || i % 5 == 0) sum += i;
            //}

            //Console.WriteLine(sum);                 // 233168
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
            //    if (i % 2 == 0) sum += i;

            //    container = i;
            //    i += n;
            //    n = container;
            //}

            //Console.WriteLine(sum);                   // 4613732
            //Console.ReadKey();
            #endregion

            #region 3. Largest Prime Factor
            // Find the is the largest prime factor of the number 600851475143

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
            //        if (sum == number) Console.WriteLine(denominator);                  // 6857
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

            //        if (((number - (number % 100000)) / 100000 == number % 10)
            //           && (((number % 100000) - (number % 10000)) / 10000 == ((number % 100) - (number % 10)) / 10)
            //           && (((number % 10000) - (number % 1000)) / 1000 == ((number % 1000) - (number % 100)) / 100))
            //        {
            //            if (number > container) container = number;
            //        }
            //    }
            //}
            //Console.WriteLine(container);             // 906609
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
            //    for (int a = lenght; a > 0; a--)
            //    {
            //        if (i % array[a - 1] == 0) counter++;
            //        else break;

            //        if (counter == lenght)
            //        {
            //            Console.WriteLine(i);                           // 232792560
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
            //    sumSq += array[a] * array[a];
            //    sqSum = sqSum + (a + 1);
            //}

            //Console.WriteLine(sqSum * sqSum - sumSq);                  // 25164150
            #endregion

            #region 7. 10001st Prime
            // What is the 10001st prime number ?

            //bool[] flags = new bool[10002];
            //int k = 0;
            //long i = 1;
            //long prime = 1;
            //int box = 0;

            //do
            //{
            //    for (long j = 1; j <= i; j++)
            //    {
            //        if (prime % j == 0) box++;

            //        if (box == 3) break;
            //    }

            //    if (box < 3)
            //    {
            //        flags[k] = true;
            //        ++k;
            //    }

            //    ++i;
            //    prime = i;
            //    box = 0;

            //}   while (flags[10001] == false);

            //Console.WriteLine(prime - 1);             // 104743
            #endregion

            #region 8. Largest Product in a Series
            //// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.
            //// 7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450

            //string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            //string[] separatedNumbers = bigNumber.Split(new char[] {'0'});
            //long bigSum = 0;
            //long sum;

            //foreach (string numbers in separatedNumbers)
            //{
            //    if (numbers.Length >= 13)
            //    {
            //        for (int i = 0; i < numbers.Length-12; i++)
            //        {
            //            sum = 1;

            //            for (int j = 0; j < 13; j++) sum *= Convert.ToInt32(char.GetNumericValue(numbers[i+j]));

            //            if (bigSum < sum) bigSum = sum;
            //        }                   
            //    }               
            //}

            //Console.WriteLine(bigSum);                // 23514624000
            #endregion
        }
    }
}
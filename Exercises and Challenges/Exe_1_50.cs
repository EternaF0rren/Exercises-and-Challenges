﻿using global::System;
using global::System.Collections.Generic;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectEulerExercises
{ 
    class Exe_1_50
    {
        static void Main()
        {
            Exe_11();
        }

        /// <summary>
        /// Multiples of 3 and 5
        /// </summary>
        static void Exe_1()
        {
            // Find the sum of all the multiples of 3 and 5 below 1000.

            int sum = 0;

            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }

            Console.WriteLine(sum);                 // 233168
            Console.ReadKey();
        }

        /// <summary>
        /// Even Fibonacci Numbers
        /// </summary>
        static void Exe_2()
        {
            // By considering the terms in the Fibonacci sequence whose values do not exceed four million,
            // find the sum of the even-valued terms.

            int sum = 0;
            int n = 1;
            int container;
            int i = 1;

            while (i <= 4_000_000)
            {
                if (i % 2 == 0) sum += i;

                container = i;
                i += n;
                n = container;
            }

            Console.WriteLine(sum);                   // 4613732
            Console.ReadKey();
        }

        /// <summary>
        /// Largest Prime Factor
        /// </summary>
        static void Exe_3()
        {
            // Find the is the largest prime factor of the number 600851475143

            long number = 600851475143;
            long denominator;
            int box;
            long sum = 1;

            for (long i = 1; i < number; i++)
            {
                denominator = i;
                box = 0;

                if (box < 3)
                {
                    for (long j = 1; j <= i; j++)
                    {
                        if (denominator % j == 0) box++;
                    }
                }
                else break;

                if (box == 2 && (number % denominator == 0))
                {
                    sum *= denominator;
                    if (sum == number) Console.WriteLine(denominator);                  // 6857
                }
            }
        }

        /// <summary>
        /// Largest Palindrome Product
        /// </summary>
        static void Exe_4()
        {
            // Find the largest palindrome made from the product of two 3-digit numbers.

            int container = 0;

            for (int i = 999; i != 100; i--)
            {
                for (int j = 999; j != 100; j--)
                {
                    int number = i * j;

                    if (((number - (number % 100000)) / 100000 == number % 10)
                       && (((number % 100000) - (number % 10000)) / 10000 == ((number % 100) - (number % 10)) / 10)
                       && (((number % 10000) - (number % 1000)) / 1000 == ((number % 1000) - (number % 100)) / 100))
                    {
                        if (number > container) container = number;
                    }
                }
            }
            Console.WriteLine(container);             // 906609
        }

        /// <summary>
        /// Smallest Multiple
        /// </summary>
        static void Exe_5()
        {
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            int i = 0;
            int lenght = 20;
            int[] array = new int[lenght];
            int counter;
            bool flag = true;

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = a + 1;
            }

            while (flag)
            {
                i++;
                counter = 0;
                for (int a = lenght; a > 0; a--)
                {
                    if (i % array[a - 1] == 0) counter++;
                    else break;

                    if (counter == lenght)
                    {
                        Console.WriteLine(i);         // 232792560
                        flag = false;
                    }
                }
            }
        }

        /// <summary>
        /// Sum Square Difference
        /// </summary>
        static void Exe_6()
        {
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            int[] array = new int[100];
            int sumSq = 0;
            long sqSum = 0;

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = a + 1;
                sumSq += array[a] * array[a];
                sqSum = sqSum + (a + 1);
            }

            Console.WriteLine(sqSum * sqSum - sumSq);                  // 25164150
        }

        /// <summary>
        /// 10001st Prime
        /// </summary>
        static void Exe_7()
        {
            // What is the 10001st prime number ?

            bool[] flags = new bool[10002];
            int k = 0;
            long i = 1;
            long prime = 1;
            int box = 0;

            do
            {
                for (long j = 1; j <= i; j++)
                {
                    if (prime % j == 0) box++;

                    if (box == 3) break;
                }

                if (box < 3)
                {
                    flags[k] = true;
                    ++k;
                }

                ++i;
                prime = i;
                box = 0;

            } while (flags[10001] == false);

            Console.WriteLine(prime - 1);             // 104743
        }

        /// <summary>
        /// Largest Product in a Series
        /// </summary>
        static void Exe_8()
        {
            //// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.
            //// 7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450

            string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            string[] separatedNumbers = bigNumber.Split(new char[] { '0' });
            long bigSum = 0;
            long sum;

            foreach (string numbers in separatedNumbers)
            {
                if (numbers.Length >= 13)
                {
                    for (int i = 0; i < numbers.Length - 12; i++)
                    {
                        sum = 1;

                        for (int j = 0; j < 13; j++) sum *= Convert.ToInt32(char.GetNumericValue(numbers[i + j]));

                        if (bigSum < sum) bigSum = sum;
                    }
                }
            }

            Console.WriteLine(bigSum);                // 23514624000
        }

        /// <summary>
        /// Special Pythagorean Triplet
        /// </summary>
        static void Exe_9()
        {
            // Find the product a*b*c, where a + b + c = 1000 and a^2 + b^2 = c^2

            bool flag = false;
            int sum = 1;

            for (int c = 499; c > 1; c--)             // c is hypotenuse and can't be more than 1/2 of 1000
            {
                int b = 1000 - c - 1;

                for (int a = 1; a < b; a++)
                {
                    if ((a + b + c == 1000) && ((c * c) == (a * a) + (b * b)))
                    {
                        flag = true;
                        sum = sum * a * b * c;
                        //Console.WriteLine($"{a} + {b} = {c} || {c*c} = {a*a} + {b*b} || {sum}");
                        break;
                    }

                    if (a + b != 1000 - c) break;

                    b--;
                }

                if (flag) break;
                
            }

            Console.WriteLine(sum);                   //31875000
        }

        /// <summary>
        /// Summation of Primes
        /// </summary>
        static void Exe_10()
        {
            // Find the sum of all the primes below two million.

            long sum = 0;
            int max = 2_000_000;
            bool[] primeArray = new bool[max];

            for (int i = 2; i * i < max; i++)
            {
                if (primeArray[i] == false)
                {
                    for (long j = i * i; j < max; j += i)
                    {
                        primeArray[j] = true;
                    }
                }
            }

            for (int k = 2; k < max; k++)
            {
                if (primeArray[k] == false) sum += k;
            }

            Console.WriteLine(sum);            // 142913828922
        }

        /// <summary>
        /// Largest Product in a Grid
        /// </summary>
        static void Exe_11()
        {
            // What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20x20 grid ?

            string numbers = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\r\n49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\r\n81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\r\n52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\r\n22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\r\n24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\r\n32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70\r\n67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21\r\n24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72\r\n21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95\r\n78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\r\n16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\r\n86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\r\n19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\r\n04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\r\n88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\r\n04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\r\n20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\r\n20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\r\n01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";

            string[] lines = numbers.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int[,] grid = new int[lines.Length, lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbersInLine = lines[i].Split(' ');

                for (int j = 0; j < numbersInLine.Length; j++)
                {
                    grid[i, j] = int.Parse(numbersInLine[j]);
                }
            }

            int sum;
            int bigSum = 1;

            // left-right diagonal
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    sum = 1;
                    sum *= grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];

                    if (sum > bigSum) bigSum = sum;
                }
            }

            // right-left diagonal
            for (int i = 19; i > 2; i--)
            {
                for (int j = 0; j < 17; j++)
                {
                    sum = 1;
                    sum *= grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3];

                    if (sum > bigSum) bigSum = sum;
                }
            }

            // vertocal
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    sum = 1;
                    sum *= grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];

                    if (sum > bigSum) bigSum = sum;
                }
            }

            // horizontal
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    sum = 1;
                    sum *= grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];

                    if (sum > bigSum) bigSum = sum;
                }
            }

            Console.WriteLine(bigSum);                // 70600674
        }

        /// <summary>
        /// Highly Divisible Triangular Number
        /// </summary>
        static void Exe_12()
        {
            // What is the value of the first triangle number to have over five hundred divisors?

            int counter = 0;
            long triangularNumber = 0;   
            int lastNumber = 1;

            while (counter <= 500)
            {
                counter = 0;
                triangularNumber += lastNumber;
                lastNumber++;              
                
                for (int i = 1; i * i <= triangularNumber; i++)
                {
                    if (triangularNumber % i == 0) counter += 2;
                }

                if (Math.Pow(Math.Sqrt(triangularNumber), 2) == triangularNumber) counter--;                
            }

            Console.WriteLine(triangularNumber);      // 76576500
        }

        /// <summary>
        /// Large Sum
        /// </summary>
        static void Exe_13()
        {
            // Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

            string numbersString = "37107287533902102798797998220837590246510135740250463769376774900097126481248969700780504170182605387432498619952474105947423330951305812372661730962991942213363574161572522430563301811072406154908250230675882075393461711719803104210475137780632466768926167069662363382013637841838368417873436172675728112879812849979408065481931592621691275889832738442742289174325203219235894228767964876702721893184745144573600130643909116721685684458871160315327670386486105843025439939619828917593665686757934951621764571418565606295021572231965867550793241933316490635246274190492910143244581382266334794475817892575867718337217661963751590579239728245598838407582035653253593990084026335689488301894586282278288018119938482628201427819413994056758715117009439035398664372827112653829987240784473053190104293586865155060062958648615320752733719591914205172558297169388870771546649911559348760353292171497005693854370070576826684624621495650076471787294438377604532826541087568284431911906346940378552177792951453612327252500029607107508256381565671088525835072145876576172410976447339110607218265236877223636045174237069058518606604482076212098132878607339694128114266041808683061932846081119106155694051268969251934325451728388641918047049293215058642563049483624672216484350762017279180399446930047329563406911573244438690812579451408905770622942919710792820955037687525678773091862540744969844508330393682126183363848253301546861961243487676812975343759465158038628759287849020152168555482871720121925776695478182833757993103614740356856449095527097864797581167263201004368978425535399209318374414978068609844840309812907779179908821879532736447567559084803087086987551392711854517078544161852424320693150332599594068957565367821070749269665376763262354472106979395067965269474259770973916669376304263398708541052684708299085211399427365734116182760315001271653786073615010808570091499395125570281987460043753582903531743471732693212357815498262974255273730794953759765105305946966067683156574377167401875275889028025717332296191766687138199318110487701902712526768027607800301367868099252546340106163286652636270218540497705585629946580636237993140746255962240744869082311749777923654662572469233228109171419143028819710328859780666976089293863828502533340334413065578016127815921815005561868836468420090470230530811728164304876237919698424872550366387845831148769693215490281042402013833512446218144177347063783299490636259666498587618221225225512486764533677201869716985443124195724099139590089523100588229554825530026352078153229679624948164195386821877476085327132285723110424803456124867697064507995236377742425354112916842768655389262050249103265729672370191327572567528565324825826546309220705859652229798860272258331913126375147341994889534765745501184957014548792889848568277260777137214037988797153829820378303147352772158034814451349137322665138134829543829199918180278916522431027392251122869539409579530664052326325380441000596549391598795936352974615218550237130764225512118369380358038858490341698116222072977186158236678424689157993532961922624679571944012690438771072750481023908955235974572318970677254791506150550495392297953090112996751986188088225875314529584099251203829009407770775672113067397083047244838165338735023408456470580773088295917476714036319800818712901187549131054712658197623331044818386269515456334926366572897563400500428462801835170705278318394258821455212272512503275512160354698120058176216521282765275169129689778932238195734329339946437501907836945765883352399886755061649651847751807381688378610915273579297013376217784275219262340194239963916804498399317331273132924185707147349566916674687634660915035914677504995186714302352196288948901024233251169136196266227326746080059154747183079839286853520694694454072476841822524674417161514036427982273348055556214818971426179103425986472045168939894221798260880768528778364618279934631376775430780936333301898264209010848802521674670883215120185883543223812876952786713296124747824645386369930090493103636197638780396218407357239979422340623539380833965132740801111666627891981488087797941876876144230030984490851411606618262936828367647447792391803351109890697907148578694408955299065364044742557608365997664579509666024396409905389607120198219976047599490197230297649139826800329731560371200413779037855660850892521673093931987275027546890690370753941304265231501194809377245048795150954100921645863754710598436791786391670211874924319957006419179697775990283006991536871371193661495281130587638027841075444973307840789923115535562561142322423255033685442488917353448899115014406480203690680639606723221932041495354150312888033953605329934036800697771065056663195481234880673210146739058568557934581403627822703280826165707739483275922328459417065250945123252306082291880205877731971983945018088807242966198081119777158542502016545090413245809786882778948721859617721078384350691861554356628840622574736922845095162084960398013400172393067166682355524525280460972253503534226472524250874054075591789781264330331690";
            int length = 50;
            int startIndex = 0;
            BigInteger sum = 0;

            while (startIndex + length <= numbersString.Length)
            {
                string numberString = numbersString.Substring(startIndex, length);

                if (BigInteger.TryParse(numberString, out BigInteger number))
                {
                    sum += number;
                }

                startIndex += length;
            }

            string firstTen = sum.ToString().Substring(0, 10);

            Console.WriteLine(firstTen);              // 5537376230
        }
    }
}
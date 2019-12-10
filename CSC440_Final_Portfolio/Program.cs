using System;

namespace CSC440_Final_Portfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LargestDivisor(100));
            //Console.WriteLine(LargestDivisor(75));
            //Console.WriteLine(LargestDivisor(66));
            //Console.WriteLine(LargestDivisor(1));

            //Console.WriteLine(ReverseString("kim"));

            //CountToThree(3);

            //Console.WriteLine(CelsiusToFahrenheight(30));

            //Console.WriteLine(BagsOfCandy(10));

            //Console.WriteLine(BuysCandy(.25));

            //Console.WriteLine(MayBuyCandy(true, false, .75));

            /*Console.WriteLine(DateNight(100));
            Console.WriteLine(DateNight(75));
            Console.WriteLine(DateNight(20));*/

            //PrintOddNumbers1To11();

            /*TakeAWalk(65);
            TakeAWalk(40);
            TakeAWalk(4);*/

            //Console.WriteLine(MultiplyingWithLoops(2, 12));

            //int[] arr = { 2, 3, 4 };
            //Console.WriteLine(AverageOfElements(arr));

            int[] arr1 = { 2, 5, 88, 99, 1, 27, 30, 0 };
            //Console.WriteLine(MinElementofArray(arr1));

            //Console.WriteLine(BuildStairs(10));

            //Countdown();

            //Console.WriteLine(FindElementIndex(arr1, 30));

            //Console.WriteLine(UniqueElementArray(arr1));

            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(IsArrayConsecutive(arr1));
            //Console.WriteLine(IsArrayConsecutive(arr));

        }
        public static int LargestDivisor(int n)
        {
            //Translated from Java

            if (n == 1)
            {
                //if n is equal to 1 it will return 1 as the largest divisor
                return 1;
            }
            int d = 2;
            while (d < n)
            {
                if (n % d == 0)
                {
                    int x = n / d;
                    return x;
                }
                d++;
            }
            return 1;
        }

        public static string ReverseString(string s)
        {
            //Leetcode problem
            //String s is input into a character array
            char[] arr = s.ToCharArray();
            //The array is reversed using the .Reverse method
            Array.Reverse(arr);
            //The new string is returned
            return new string(arr);
        }

        public static void CountToThree(int i)
        {
            //Translated from Java.
            //Console prints out one, two, three on separate lines.
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
        }

        public static double CelsiusToFahrenheight(double degreesCel)
        {
            //Translated from Java
            //Used math to convert celsius to fahrenheight
            return degreesCel * 1.8 + 32;
        }

        public static double BagsOfCandy(int kids)
        {
            //Translated from Java
            //Function used to figure out how many bags of candy to buy for Halloween.
            double candyPerBag = 20;
            double candyPerKid = 1;
            return (kids * candyPerKid / candyPerBag);
        }

        public static bool BuysCandy(double moneyWallet)
        {
            //Translated from Java
            //Function that determins if someone has enough money to buy candy that costs 50 cents
            if (moneyWallet >= .50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MayBuyCandy(bool mother, bool father, double money)
        {
            //Translated from Java
            //If a child has permission from at least one parent and has at least .75 cents they can buy candy.
            if (money >= .75 && (mother || father))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double DateNight(double money)
        {
            //Translated from Java
            //A couple goes out to dinner, if they have enough money for two entrees, an appetizer, and dessert, they will buy all of them.
            //If they have enough for two entrees and an app they will buy that, if not they will buy two entrees and dessert.
            //If they don't have enough money for two entrees they will not spend any money at the restaurant.

            double entree = 40.0;
            double app = 10.0;
            double dessert = 7.50;

            if (money >= entree)
            {
                double moneyAfterEntree = money - entree;

                if (moneyAfterEntree >= app)
                {
                    double moneyAfterApp = moneyAfterEntree - app;

                    if (moneyAfterApp >= dessert)
                    {
                        //This will return if they have enough money for both entrees, one appetizer, and one dessert.
                        double moneyAfterDessert = moneyAfterApp - dessert;
                        return moneyAfterDessert;
                    }
                    //This will return if they have enough money for both entrees and one appetizer.
                    return moneyAfterApp;
                }
                else if (moneyAfterEntree >= dessert)
                {
                    //This will return if they have enough money for both entrees and one dessert.
                    double moneyAfterDessert = moneyAfterEntree - dessert;
                    return moneyAfterDessert;
                }
                else
                {
                    //This will return if they only have enough money for two entrees.
                    return moneyAfterEntree;
                }
            }
            else
            {
                //This will return their original money ammount because they cannot afford the two entrees.
                return money;
            }
        }

        public static void PrintOddNumbers1To11()
        {
            //Translated from Java
            //Will print odd numbers from 1 to 11

            int n = 1;
            while (n <= 11)
            {
                Console.WriteLine(n);
                n += 2;
            }
        }

        public static void TakeAWalk(int a)
        {
            //Translated from Java
            //Input the amount of time available to see where you can walk to
            //An hour or more you can walk to the store, less than an hour but at least 10 min can walk around the block
            //less than 10 min and there is no time for a walk.
            if (a >= 60)
            {
                Console.WriteLine("Store");
            }
            else if (a < 60 && a >= 10)
            {
                Console.WriteLine("Block");
            }
            else
            {
                Console.WriteLine("No walk for you");
            }
        }

        public static int MultiplyingWithLoops(int a, int b)
        {
            //Translated from Java
            //Create a function that will multiply with loops instead of using the * operator.

            int multiple = a;
            int number = 1;
            if (a == 0 || b == 0)
            {
                return 0;
            }
            while (b > number)
            {
                number++;
                multiple += a;
            }
            return multiple;
        }

        public static double AverageOfElements(int[] arr)
        {
            //Translated from Java
            //Given an integer array, find the average of the elements in that array.

            double total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //finds the total of all the added up elements of the array
                total += arr[i];
            }
            //divides by the array length to find the average
            double average = total / arr.Length;
            return average;
        }

        public static int MinElementofArray(int[] arr)
        {
            //Translated from Java
            //Iterates through the array and updates "smallest" to find the smallest variable.
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }

        public static int BuildStairs(int blocks)
        {
            //Translated from Java
            //If you had 5 blocks, you could only build 2 stairs (which requires 1+2 = 3 blocks) and not 3 stairs(which would need 1+2+3 = 6 blocks).
            int stairs = 0;
            for (int i = 1; i <= blocks; i++)
            {
                if (i <= blocks)
                {
                    stairs++;
                    blocks = blocks - i;
                }
            }
            return stairs;
        }

        public static void Countdown()
        {
            //Translated from Java
            //Counts down from 10 to 1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static int FindElementIndex(int[] arr, int b)
        {
            //Translated from Java
            //Returns the index of the element you are searching for in an integer array. If the element does not exist it will return -1.

            if (arr.Length == 0)
            {
                return -1;
            }
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == b)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool UniqueElementArray(int[] arr)
        {
            //Translated from Java
            //Returns true if every element in an array is unique and false if it isn't.
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsArrayConsecutive(int[] arr)
        {
            //Translated from Java
            //If elements in an int array are consecutive it returns true, if not, false.
            if (arr.Length == 1)
            {
                return true;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}

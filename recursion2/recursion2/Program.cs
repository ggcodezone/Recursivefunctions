using System;

//Name:Prime Number Finder
//Author: Gwen Kalasky
//Synopsis: This program will tell you whether or not the input is a prime number
//Date: Nov. 5th 2020
namespace recursion2
{
    class Primefind
    {
        // returns true if n is prime, and if it isnt, returns false. 
        static bool isPrime(int n, int i)
        {

            // Base cases 
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;

            // Check for next divisor 
            return isPrime(n, i + 1);
        }
        class Program
    {
        static void Main(string[] args)
        {

            {
                int n = 25; //put the number you want to check here

                if (isPrime(n, 2))
                    Console.Write("Yes"); //the output seen by user 
                    Console.Write("No");
            }

        }
    }
    }
}

using System;
//Name:Random Number Generator
//Author:Gwen Kalasky
//Synopsis: Will generate a random number based on parameters set by user
//Date: Nov. 4th 2020
namespace recurssion
{
    class Program
    {
        static void Main(string[] args)
        {
            string allowedCharacters = "1234567890";
           Random rnd = new Random();
             string randomString(int length)
            {
                if (length == 0)
                    return "";
                return allowedCharacters[rnd.Next(0, allowedCharacters.Length)]
                       + randomString(length - 1);   // the recursive call
            }

            // you can use this to display a random number (the max and min length of which is determined
            //in the brackets after "rnd.Next")
            Console.WriteLine(randomString(rnd.Next(1, 4)));

        }
    }
}


using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Library
{
    public class FizzBuzzClass
    {
        //This is something called fizzbuzz
        /*
        
        if divisible by 3 returns "fizz"
        if divisible by 5 returns "buzz"
        if divisible by 5 and 3 returns "fizzbuzz"

        HINT: *order

         */
        //Difficulty 2/5
        public static string FizzBuzz(int number)
        {
            bool fizz = (number % 3 == 0);
            bool buzz = (number % 5 == 0);

            
            if (fizz == true)
            {
                Convert.ToString("fizz");
                return "fizz";
            }
            if (buzz == true)
            {
                Convert.ToString("buzz");
                return "buzz";
            }

            return ;
           
        }
    }
}
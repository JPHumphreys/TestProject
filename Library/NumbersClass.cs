
using System;
using System.Collections.Generic;

namespace Library
{
    public class NumbersClass
    {
        //This function checks if something is divisible by 4 or 6
        //returns true if so
        //returns false if not

        //Difficulty 2/5
        public static bool IsDivisibleBy4or6(int num)
        {
            if (num % 4 == 0) {
                return true;
            }
            if (num % 6 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //This function multiplies the number recieved in paramater by 10
        //and returns it

        //Difficulty 1/5
        public static int MultiplyBy10(int num)
        {
            int response = num * 10;

            return response;
        }

        //This function gets the difference between these two numbers
        //HINT: always positive integer

        //Difficulty 3/5
        public static int Difference(int num1, int num2)
        {
            
            int result = num1 - num2;

            bool negative = result < 0;

            if (negative == true)
            {
               return result*-1;
            }

            return result;
        }


        //Floor returns the closest int for the value
        //Google Math.Floor
        //Difficulty 1/5
        public static int FloorValue(decimal num)
        {
            
            return -1;
        }

        
        //Google Math.sqrt
        //and maybe the thoerem
        //Difficulty 2/5
        public static double PythagoreanTheorem(int a, int b)
        {

            return 0.0;
        }
    }
}

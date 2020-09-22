
using System;
using System.Linq;

namespace Library
{
    public class StringClass
    {
        //This function counts how many Js there are in a string

        //eg "ehj" = 1, "jjj" = 3
        // 

        //Difficulty 3/5
        public static int CountJs(string testString)
        {
            string lowerString = testString.ToLower();
            var counter = 0;
            char compare = 'j';

            for (int i = 0; i < lowerString.Length; i++)
            {
                char character = lowerString[i];
                if (character == compare)
                {
                    counter += 1;
                }
            }
            return counter;
         }


        //This functions removed undesirables from a string
        //It removes :
            //Trailing whitespace
                // "     eg      "
            //hyphens
                // "----eg----"
            //make it lowercase
                // "ARGH" => "argh"

        //Difficulty 4/5
        public static string RemoveArtefacts(string testString)
        {
            return testString.Trim(' ','-').ToLower();
        }

        //SUPER BLOCK
        //This is a function that returns an integer
        //for the longest chain of a certain char in a string
        // for example:

        //
            /*
            "ACIEWHJSLKOSJDOD" returns 1
            "ss" return 2
            "sS" return 1
            "cjeijifjDDDDdoj3iufji3j" returns 4
            */
        //

        //Difficulty 5/5
        public static int SuperBlock(string testString)
        {
            var counter = 0;
            var longestChain = 0;
            char lastCharacter = testString[0];

            if(testString[0] == ' ')
            {
                return 0;
            }
            for (int i = 0; i < testString.Length; i++)
            {
                char character = testString[i];
                if ( character == lastCharacter)
                {
                    counter += 1;
                }
                else
                {
                    counter = 0;
                }
                
                if(counter > longestChain)
                {
                    longestChain = counter;
                }
                lastCharacter = character;
            }
            return longestChain;
        }

        //This function checks if the string is the same forward as backwards
        // eg => "racecar" or "wow"

        //HINT: for loops can go backwards too! i--

        //Difficulty 5/5
        public static bool IsPalindrome(string testString)
        {
            string forwardString = testString;
            string backwardString = "";

            for (int i = testString.Length -1; i >=0; i--)
            {
                string character = testString[i].ToString();
                backwardString += character;
            }
            
            if (forwardString == backwardString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //this will require a loop of some sorts
        //Google ceaser cipher
            //basically shifts chars along an amount to make coded messages
            //google ascii table 72-98
            //google convert char to int c#

            //what happends - what can you do
            //when shifting z

        //this may take some time but can be fun
        //Difficulty 5/5
        public static string CeaserCipher(int shift, string testString)
        {
            var zAcsiiValue = 122;
            var aAsciiValue = 97;

            for (int i = 0; i < testString.Length; i++)
            {
                var currentCharAsInt = Convert.ToInt32(testString[i]);
            }



            return "";
        }


        //youll need to SPLIT the string via the commas
        //this can be done with a string function
        //..that returns a bool - have a google and see if you can find it!
        //becuase coding as a proffession requires being a proffesional googler
        //Difficulty 3/5
        public static bool DoesListContainKevin(string testString)
        {
            var lowerString = testString.ToLower();
            var splitString = lowerString.Split(",");
            if (splitString.Contains("kevin") )
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        //this will require a loop
        //HINT:
            //its very important you consider how long the string is
        //and dont try to look for something that is...
        // "Exception: out of range"
        //which happends when you try to look for a value..
        //in an array that is higher than the length of the array
            //EG if you have arr[7] and try to look for arr[8]
                //computer goes LOCO
                //an if statement can fix this problem

        //so youll need to consider this
        //Difficulty 4/5
        
        public static int KevinCounter(string testString)
        {
            var stringToLookFor = "kevin";
            var counter = 0;
            var lowerString = testString.ToLower();

            for (int i = 0; i < (lowerString.Length - stringToLookFor.Length); i++)
            {
                if (lowerString.Substring(i,i+5) == stringToLookFor)
                {
                    counter +=1;

                    if ((i+5)>lowerString.Length)
                    {
                        break;
                    }
                }


            }

            return counter;
        }
    }
}

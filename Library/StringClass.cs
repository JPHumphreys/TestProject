
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

            return -1;
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




            return "test";
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

            return -1;
        }

        //This function checks if the string is the same forward as backwards
        // eg => "racecar" or "wow"

        //HINT: for loops can go backwards too! i--

        //Difficulty 5/5
        public static bool IsPalindrome(string testString)
        {

            return true;
        }


        //this will require a loop of some sorts
        //Google ceaser cipher
            //basically shifts chars along an amount to make coded messages
            //google ascii table
            //google convert char to int c#
        //this may take some time but can be fun
        //Difficulty 5/5
        public static string CeaserCipher(int shift, string testString)
        {

            return "";
        }


        //youll need to SPLIT the string via the commas
        //this can be done with a string function
            //..that returns a bool - have a google and see if you can find it!
            //becuase coding as a proffession requires being a proffesional googler
        //Difficulty 3/5
        public static bool DoesListContainKevin(string testString)
        {
            return false;
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
            return -1;
        }
    }
}

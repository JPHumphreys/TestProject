using Xunit;
using Library;

namespace TestProject
{
    public class UnitTest
    {
        [Theory]
        [InlineData(5, "buzz")]
        [InlineData(10, "buzz")]
        [InlineData(20, "buzz")]
        public void FizzBuzz_WhenDivisibleBy5_ReturnBuzz(int number, string result)
        {
            var test = FizzBuzzClass.FizzBuzz(number);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData(3, "fizz")]
        [InlineData(6, "fizz")]
        [InlineData(9, "fizz")]
        public void FizzBuzz_WhenDivisibleBy3_ReturnFizz(int number, string result)
        {
            var test = FizzBuzzClass.FizzBuzz(number);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData(15, "fizzbuzz")]
        [InlineData(30, "fizzbuzz")]
        [InlineData(45, "fizzbuzz")]
        public void FizzBuzz_WhenDivisibleBy5And3_ReturnFizzBuzz(int number, string result)
        {
            var test = FizzBuzzClass.FizzBuzz(number);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData("CaSe Is WeiRD", "case is weird")]
        [InlineData("I'M SHOUTING", "i'm shouting")]
        [InlineData("this is a SNEAKY shout", "this is a sneaky shout")]
        public void RemoveArtefacts_WhenCaseIsIncorrect_MakeLowerCase(string testString, string result)
        {
            var test = StringClass.RemoveArtefacts(testString);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData("-----hehe------", "hehe")]
        [InlineData("--xx--coolwhip--xx--", "xxcoolwhipxx")]
        [InlineData("-x-", "x")]
        public void RemoveArtefacts_WhenThereIsHyphens_RemoveThem(string testString, string result)
        {
            var test = StringClass.RemoveArtefacts(testString);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("aartyu", 2)]
        [InlineData("DDDDee", 4)]
        [InlineData("sS", 1)]
        public void SuperBlock_WhenStringContainsMultipleCharacters_ReturnLargestChain(string testString, int result)
        {
            var test = StringClass.SuperBlock(testString);

            Assert.True(result == test);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(12)]
        [InlineData(16)]
        public void IsDivisible_WhenBy4or6_ReturnTrue(int num)
        {
            var test = NumbersClass.IsDivisibleBy4or6(num);

            Assert.True(test);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void IsDivisible_WhenNOTBy4or6_ReturnFalse(int num)
        {
            var test = NumbersClass.IsDivisibleBy4or6(num);

            Assert.False(test);
        }

        [Theory]
        [InlineData(1,10)]
        [InlineData(5,50)]
        [InlineData(10,100)]
        public void MultiplyBy10_WhenAble_ReturnCorrectValue(int num, int expected)
        {
            var test = NumbersClass.MultiplyBy10(num);

            Assert.Equal(expected, test);
        }

        [Theory]
        [InlineData(1,10)]
        [InlineData(50,5)]
        [InlineData(10,100)]
        [InlineData(2,1)]
        public void Difference_WhenValuesPresentANegative_ReturnPositive(int num1, int num2)
        {
            var test = NumbersClass.Difference(num1, num2);

            Assert.True(test > 0);
        }

        [Theory]
        [InlineData(1,10,9)]
        [InlineData(5,2,3)]
        [InlineData(99,99,0)]
        public void Difference_WhenValuesAreDifferent_ReturnDifference(int num1, int num2, int expected)
        {
            var test = NumbersClass.Difference(num1, num2);

            Assert.Equal(expected,test);
        }

        [Theory]
        [InlineData("wow")]
        [InlineData("racecar")]
        [InlineData("cockkcoc")]
        public void IsPalindrome_WhenValuesAreAPalindrome_ReturnTrue(string testString)
        {
            var test = StringClass.IsPalindrome(testString);

            Assert.True(test);
        }

        [Theory]
        [InlineData("won")]
        [InlineData("race")]
        [InlineData("cock")]
        public void IsPalindrome_WhenValuesAreNotAPalindrome_ReturnFalse(string testString)
        {
            var test = StringClass.IsPalindrome(testString);

            Assert.False(test);
        }

        [Theory]
        [InlineData("won", 0)]
        [InlineData("jjj", 3)]
        [InlineData("jonathan", 1)]
        public void CountJs_WhenCounting_ReturnCorrectValue(string testString, int expected)
        {
            var test = StringClass.CountJs(testString);

            Assert.Equal(expected,test);
        }

        [Theory]
        [InlineData("won", 0)]
        [InlineData("jJj", 3)]
        [InlineData("Jonathan", 1)]
        public void CountJs_WhenCountingUpperCase_ReturnCorrectValue(string testString, int expected)
        {
            var test = StringClass.CountJs(testString);

            Assert.Equal(expected, test);
        }

        [Theory]
        [InlineData(0.2018, 0)]
        [InlineData(123.123, 123)]
        [InlineData(-0.2, -1)]
        public void FloorValue_WhenValueIsFloorable_ReturnCorrectValue(decimal num, int result)
        {
            var test = NumbersClass.FloorValue(num);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData(2,3,3.61)]
        [InlineData(23,5,23.54)]
        [InlineData(7,9,11.4)]

        public void PythagoreanTheorem_WhenValuesAreCorrect_ReturnCorrectValues(int a, int b, double result)
        {
            var test = NumbersClass.PythagoreanTheorem(a, b);

            Assert.Equal(result, test);
        }

        [Theory]
        [InlineData(7, "If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out.", "Pm ol ohk hufaopun jvumpkluaphs av zhf, ol dyval pa pu jpwoly, aoha pz, if zv johunpun aol vykly vm aol slaalyz vm aol hswohila, aoha uva h dvyk jvbsk il thkl vba.")]
        [InlineData(5, "If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out.", "Nk mj mfi fsdymnsl htsknijsynfq yt xfd, mj bwtyj ny ns hnumjw, ymfy nx, gd xt hmfslnsl ymj twijw tk ymj qjyyjwx tk ymj fqumfgjy, ymfy sty f btwi htzqi gj rfij tzy.")]
        [InlineData(2, "If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out.", "Kh jg jcf cpavjkpi eqphkfgpvkcn vq uca, jg ytqvg kv kp ekrjgt, vjcv ku, da uq ejcpikpi vjg qtfgt qh vjg ngvvgtu qh vjg cnrjcdgv, vjcv pqv c yqtf eqwnf dg ocfg qwv.")]
        public void CeaserCipher_WhenShiftSet_ShiftValuesThatMuch(int shift, string testString, string expected)
        {
            var test = StringClass.CeaserCipher(shift, testString);
            Assert.Equal(expected, test);
        }
    }
}

using System;
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
        public void SuperBlock_WhenStringIsNull_Return0(string testString, int result)
        {
            var test = StringClass.SuperBlock(testString);

            Assert.True(result == test);
        }
    }
}

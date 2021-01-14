using Systemio;
using Xunit;

namespace LAB3_Tests
{
    public class ChallengeOneTests
    {
        [Fact]
        public void TestChallengeOneStringOfNumbersReturnsProductOfNumbers()
        {
            string testInput = "4,5,6";
            Assert.Equal(120, Program.ChallengeOne(testInput));
        }
        [Fact]
        public void TestChallengeOneMoreThanThreeNumbers()
        {
            string testInput = "5, 8, 7, 40, 50";
            Assert.Equal(280, Program.ChallengeOne(testInput));
        }
        [Fact]
        public void TestChallengeOneLessThanThreeNumbers()
        {
            string testInput = "10, 20";
            Assert.Equal(0, Program.ChallengeOne(testInput));
        }
        [Fact]
        public void TestChallengeOneNegativeNumbers()
        {
            string testInput = "-2, 4, 6";
            Assert.Equal(-48, Program.ChallengeOne(testInput));
        }


        [Fact]
        public void TestChallengeFiveWithNegatives()
        {
            int[] testArray = new int[] { -1, -20, -30, -2, -45, -1 };
            Assert.Equal(-1, Program.ChallengeFive(testArray));

        }

        [Fact]
        public void TestAllSame()
        {
            int[] testArray = new int[] { 1, 1, 1, 1, 1 };
            Assert.Equal(1, Program.ChallengeFive(testArray));
        }
    }
    public class ChallengeTwoTests
    {
        //Test
        [Theory]
        [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 121)]
        [InlineData(new int[] { 4, 8, 15, 16 }, 10)]
        [InlineData(new int[] { 12, 24, 32, 44 }, 28)]

        public void ChallengeTwoTestAverage(int[] value, int expected)
        {
            Assert.Equal(expected, Program.ChallengeTwo(value));
        }

        //My Code will ensure input. Not sure how to do it here.

        [Fact]
        public void ChallengeTwoTestAverageAllZeros()
        {
            int[] testArray = new int[] { 0, 0, 0, 0 }; //121
            Assert.Equal(0, Program.ChallengeTwo(testArray));
        }

    }

    public class ChallengeFourTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 6, 4, 5, 1, 4, 4, 4, 2, 2, 2, 5, 7, 55, 4, 4 }, 4)]
        [InlineData(new int[] { 2, 4, 4, 2, 2, 2, 5 }, 2)]
        [InlineData(new int[] { 7 }, 7)]

        public void ChallengeFourDifferentSizeArrays(int[] expected, int value)
        {
            Assert.Equal(Program.ChallengeFour(expected), value);
        }
        [Fact]
        public void ChallengeFourAllSameValue()
        {
            int[] value = new int[] { 3, 3, 3, 3, 3, 3 };
            Assert.Equal(3, Program.ChallengeFour(value));
        }
        [Fact]
        public void ChallengeFourNoRepeatedValue()
        {
            int[] value = new int[] { 4, 3, 2, 1, 6, 9 };
            Assert.Equal(4, Program.ChallengeFour(value));
        }
        [Fact]
        public void ChallengeFourSameAmountRepeated()
        {
            int[] value = new int[] { 3, 3, 3, 4, 4, 4 };
            Assert.Equal(3, Program.ChallengeFour(value));
        }

    }
    public class ChallengeFiveTests
    {
        [Fact]
        public static void ChallengeFiveMaxValue ()
        {
            int[] value = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            Assert.Equal(555, Program.ChallengeFive(value));
        }
        [Fact]
        public static void ChallengeFiveAllValuesSame()
        {
            int[] value = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            Assert.Equal(5, Program.ChallengeFive(value));
        }

    }
    public class ChallengeNineTests
    {
        [Fact]
        public static void 
    }

}






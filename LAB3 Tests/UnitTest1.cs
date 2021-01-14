using System;
using Xunit;
using Systemio;

namespace LAB3_Tests
{
    public class Lab3Test
    {
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
}

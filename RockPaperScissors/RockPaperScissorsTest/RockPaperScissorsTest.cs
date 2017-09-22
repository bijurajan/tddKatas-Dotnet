using System;
using Xunit;

namespace Katas
{
    public class RockPaperScissorsTest
    {
        [Fact]
        public void rockShouldCrushScissors()
        {
            RockPaperScissors game = new RockPaperScissors();

            string actualResult = game.determineWinner("rock", "scissors");
            string expectedResult = "rock beats scissors";

            Assert.Equal(expectedResult, actualResult);
        }
    }
}

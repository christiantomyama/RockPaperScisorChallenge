using RockPaperScissor.Domain.Exceptions;
using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;
using Xunit;

namespace RockPaperScissor.Domain.Test
{
    public class RpsConfrontSpecs
    {
        [Fact]
        public void AssertPlayer1Wins()
        {
            Player player1 = new Player("Armando", "R");
            Player player2 = new Player("Dave", "S");

            RpsConfront confront = new RpsConfront();
            IPlayer winner = confront.FindWinner(player1, player2);

            Assert.Equal(winner, player1);
        }

        [Fact]
        public void AssertPlayer2Wins()
        {
            Player player1 = new Player("Armando", "R");
            Player player2 = new Player("Dave", "P");

            RpsConfront confront = new RpsConfront();
            IPlayer winner = confront.FindWinner(player1, player2);

            Assert.Equal(winner, player2);
        }

        [Fact]
        public void TournamentMustBePlayedByTwoPlayer()
        {
            Player player1 = new Player("Armando", "A");
            Player player2 = new Player("Dave", "B");


            Assert.Throws<NoSuchStrategyError>(
                () =>
                {
                    RpsConfront confront = new RpsConfront();
                    confront.FindWinner(player1, player2);
                }
            );

        }
    }
}

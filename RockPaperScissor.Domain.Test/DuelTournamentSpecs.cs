using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;
using RockPaperScissor.Domain.Tournament.Duel;
using System.Collections.Generic;
using Xunit;
using RockPaperScissor.Domain.Exceptions;

namespace RockPaperScissor.Domain.Test
{
    public class DuelTournamentSpecs
    {
        [Fact]
        public void TestThreeDimentionalTournament()
        {
            List<object> playerList = getPlayerList();
            DuelTournament tournament = DuelTournament.Build();
            IPlayer winner = tournament.FindWinner(playerList);

            Assert.Equal("Omer", winner.Name);
        }

        public List<object> getPlayerList()
        {
            List<object> threeDimentionalList = new List<object>()
             {
                new List<object>()
                {
                    new List<object>()
                    {
                        new Player("Armando", "3"), new Player("Dave", "5"),
                    },
                    new List<object>()
                    {
                        new Player("Richard", "1"), new Player("Michael", "11"),
                    }
                },
                new List<object>()
                 {
                    new List<object>()
                    {
                        new Player("Allen", "5"), new Player("Omer", "12"),
                    },
                    new List<object>()
                    {
                        new Player("David E.", "2"), new Player("Richard X", "7"),
                    }
                }
            };
            return threeDimentionalList;
        }

    }
}

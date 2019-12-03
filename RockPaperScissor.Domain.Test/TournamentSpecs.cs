using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using RockPaperScissor.Domain.Exceptions;

namespace RockPaperScissor.Domain.Test
{
    public class TournamentSpecs
    {
        [Fact]
        public void TestThreeDimentionalTournament()
        {
            List<object> playerList = getPlayerList();
            RpsTournament tournament = RpsTournament.Build();
            IPlayer winner = tournament.FindWinner(playerList);
            Assert.Equal("Richard", winner.Name);
        }

        [Fact]
        public void TournamentMustBePlayedByTwo()
        {
            List<object> playerList = new List<object>()
            {
                new Player("Armando", "P"),
                new Player("Dave", "S"),
                new Player("Dave", "S"),
            };

            Assert.Throws<WrongNumberOfPlayersError>(
                () =>
                {
                    RpsTournament tournament = RpsTournament.Build();
                    IPlayer winner = tournament.FindWinner(playerList);
                }
            );

        }

        public List<object> getPlayerList()
        {
            List<object> threeDimentionalList = new List<object>()
             {
                new List<object>()
                {
                    new List<object>()
                    {
                        new Player("Armando", "P"), new Player("Dave", "S"),
                    },
                    new List<object>()
                    {
                        new Player("Richard", "R"), new Player("Michael", "S"),
                    }
                },
                new List<object>()
                 {
                    new List<object>()
                    {
                        new Player("Allen", "S"), new Player("Omer", "P"),
                    },
                    new List<object>()
                    {
                        new Player("David E.", "R"), new Player("Richard X", "P"),
                    }
                }
            };
            return threeDimentionalList;
        }

    }
}

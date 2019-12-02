using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;

namespace RockPaperScissor.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            RpsTournament tournament = RpsTournament.Build();


            List<object> oneDimentionalList = new List<object>()
            {
                new Player("Armando", "P"),
                new Player("Dave", "S"),
            };

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


            IPlayer firstTournamentWinner = tournament.FindWinner(oneDimentionalList);
            Console.WriteLine("Simple game winner");
            Console.WriteLine(firstTournamentWinner + Environment.NewLine);

            IPlayer secondTournamentWinner = tournament.FindWinner(threeDimentionalList);
            Console.WriteLine("Tournament winner");
            Console.WriteLine(secondTournamentWinner);
        }

    }
}

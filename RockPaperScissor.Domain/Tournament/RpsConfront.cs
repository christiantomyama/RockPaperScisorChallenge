using RockPaperScissor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Domain.Tournament
{
    class RpsConfront : IConfront
    {
        private Dictionary<string, string> WinCondition { get; set; }
        private string[] ValidCommand { get; set; }
        public RpsConfront()
        {
            MapValidCommand();
            MapWinCondition();
        }
        public void MapValidCommand()
        {
            ValidCommand = new string[] { "R", "P", "S" };
        }
        public void MapWinCondition()
        {
            WinCondition = new Dictionary<string, string>()
            {
                {"R", "S"},
                {"S", "P"},
                {"P", "R"}
            };

            Console.WriteLine(WinCondition["R"]);
        }

        public IPlayer FindWinner(IPlayer player1, IPlayer player2)
        {
            if (player1.Command == player2.Command)
            {
                return player1;
            }

            return WinCondition[player1.Command] == player2.Command ? player1 : player2;
        }

    }
}

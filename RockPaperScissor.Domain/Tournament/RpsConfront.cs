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
            ValidCommand = new string[] {
                RpsCommand.Rock,
                RpsCommand.Paper,
                RpsCommand.Scissor
            };
        }
        public void MapWinCondition()
        {
            WinCondition = new Dictionary<string, string>()
            {
                {RpsCommand.Rock, RpsCommand.Scissor},
                {RpsCommand.Scissor, RpsCommand.Paper},
                {RpsCommand.Paper, RpsCommand.Rock}
            };

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

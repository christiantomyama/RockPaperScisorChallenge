using RockPaperScissor.Domain.Interfaces;
using System.Collections.Generic;

namespace RockPaperScissor.Domain.Tournament
{
    public class RpsConfront : IConfront
    {
        private Dictionary<string, string> WinCondition { get; set; }
        private IConfrontValidation ConfrontValidation { get; set; }
        public RpsConfront()
        {
            Init();
            MapWinCondition();
        }
        public void Init()
        {
            ConfrontValidation = new RpsConfrontValidation();
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
            ConfrontValidation.ValidatePlayer(player1);
            ConfrontValidation.ValidatePlayer(player2);

            if (player1.Command == player2.Command)
            {
                return player1;
            }

            return WinCondition[player1.Command] == player2.Command 
                ? player1 
                : player2;
        }

    }
}

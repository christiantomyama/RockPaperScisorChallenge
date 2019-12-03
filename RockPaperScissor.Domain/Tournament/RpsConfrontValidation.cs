using RockPaperScissor.Domain.Exceptions;
using RockPaperScissor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissor.Domain.Tournament
{
    public class RpsConfrontValidation : IConfrontValidation
    {
        private string[] ValidCommand { get; set; }
        public RpsConfrontValidation()
        {
            MapValidCommand();
        }
        public void MapValidCommand()
        {
            ValidCommand = new string[] {
                RpsCommand.Rock,
                RpsCommand.Paper,
                RpsCommand.Scissor
            };
        }
        public void ValidatePlayer(IPlayer player)
        {
            if (!ValidCommand.Contains(player.Command))
            {
                throw new NoSuchStrategyError(player.Command);
            }
        }

    }
}

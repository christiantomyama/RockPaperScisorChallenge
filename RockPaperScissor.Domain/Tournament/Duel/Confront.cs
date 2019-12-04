using RockPaperScissor.Domain.Exceptions;
using RockPaperScissor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissor.Domain.Tournament.Duel
{
    public class Confront : IConfront
    {
        public Confront()
        {
        }

        public IPlayer FindWinner(IPlayer player1, IPlayer player2)
        {
            int power1 = Int32.Parse(player1.Command);
            int power2 = Int32.Parse(player2.Command);

            if (power1 == power2)
            {
                return player1;
            }

            return power1 > power2 ? player1 : player2;
        }

    }
}

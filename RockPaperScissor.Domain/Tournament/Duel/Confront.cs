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
            int i1 = Int32.Parse(player1.Command);
            int i2 = Int32.Parse(player2.Command);

            if (i1 == i2)
            {
                return player1;
            }

            return i1 > i2 ? player1 : player2;
        }

    }
}

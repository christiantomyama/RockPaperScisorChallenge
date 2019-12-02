using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Domain.Interfaces
{
    public interface IConfront
    {
        IPlayer FindWinner(IPlayer player1, IPlayer player2);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Domain.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Command { get; set; }

    }
}

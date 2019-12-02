using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public string Command { get; set; }

        //public Player(IList args): this(args[0] as string, args[1]) {        }
        public Player(string name, string command)
        {
            Name = name;
            Command = command.ToUpper();
        }

        public override string ToString()
        {
            return GetType().Name + $" [Name={Name}, Command={Command}]";
        }
    }
}

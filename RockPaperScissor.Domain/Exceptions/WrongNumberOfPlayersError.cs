﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Domain.Exceptions
{
    class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError(int wrongNumberOfPlayer) :
            base(ModifyMessage(wrongNumberOfPlayer))
        {
            
        }

        private static string ModifyMessage(int wrongNumberOfPlayer)
        {
            return $"Invalid Number of Player ({wrongNumberOfPlayer}). Tournmant Match must be played by 2.";
        }

    }
}
using System;

namespace RockPaperScissor.Domain.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string invalidStrategy) :
            base(ModifyMessage(invalidStrategy))
        {

        }

        private static string ModifyMessage(string invalidStrategy)
        {
            return $"Invalid Strategy({invalidStrategy}) Error. Please Check your Strategy.";
        }
    }
}

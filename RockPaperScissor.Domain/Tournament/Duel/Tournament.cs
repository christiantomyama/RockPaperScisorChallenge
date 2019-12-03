using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament.Duel
{
    public class RpsTournament : Tournament
    {
        public RpsTournament(IConfront confront) : base(confront)
        {
        }

        public static RpsTournament Build()
        {
            IConfront confront = new Confront();
            return new RpsTournament(confront);
        }
     

    }
}

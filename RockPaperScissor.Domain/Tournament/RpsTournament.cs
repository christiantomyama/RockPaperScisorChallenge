using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament
{
    public class RpsTournament : Tournament
    {
        public RpsTournament(IConfront confront) : base(confront)
        {
        }

        public static RpsTournament Build()
        {
            IConfront confront = new RpsConfront();
            return new RpsTournament(confront);
        }
     

    }
}

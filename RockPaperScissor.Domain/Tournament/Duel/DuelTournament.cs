using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament.Duel
{
    public class DuelTournament : Tournament
    {
        public DuelTournament(IConfront confront) : base(confront)
        {
        }

        public static DuelTournament Build()
        {
            IConfront confront = new Confront();
            return new DuelTournament(confront);
        }
     

    }
}

using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using RockPaperScissor.Domain.Exceptions;
using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament
{
    public class Tournament
    {
        public const int NUMBER_OF_PLAYERS = 2;
        public IConfront Confront { get; set; }

        public Tournament(IConfront confront)
        {
            Confront = confront;
        }
        public IPlayer FindWinner(IList array)
        {
            return FindWinner(ConvertJArrayToPlayerList(array));
        }

        private List<object> ConvertJArrayToPlayerList(IList list)
        {
            List<object> playerList = new List<object>();
            object firstElement = list[0];
            if (!(firstElement is IList))
            {
                string name = list[0].ToString();
                string command = list[1].ToString();
                IPlayer player = new Player(name, command);

                playerList.Add(player);

                return playerList;
            }
            foreach (IList innerArray in list)
            {
                List<object> innerList = ConvertJArrayToPlayerList(innerArray);
                playerList.Add(innerList.Count == 1 ? innerList[0] : innerList);
            }

            return playerList;
        }

        public IPlayer FindWinner(List<object> playerList)
        {
            if (playerList.Count != NUMBER_OF_PLAYERS)
            {
                throw new WrongNumberOfPlayersError(playerList.Count);
            }

            while (true)
            {
                object firstElement = playerList[0];
                object secondElement = playerList[1];
                if (firstElement is IPlayer && secondElement is IPlayer)
                {
                    IPlayer winner = Confront.FindWinner(firstElement as IPlayer, secondElement as IPlayer);
                    return winner;
                }

                for (var i = 0; i < playerList.Count; i++)
                {
                    if (playerList[i] is IPlayer)
                    {
                        continue;
                    }
                    List<object> innerList = playerList[i] as List<object>;
                    IPlayer winner = FindWinner(innerList);
                    playerList[i] = winner;
                    if (playerList.Count == 1)
                    {
                        return winner;
                    }
                }
            }
        }

    }
}

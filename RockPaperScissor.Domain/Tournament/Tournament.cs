using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament
{
    public class Tournament
    {
        public IConfront Confront { get; set; }
        public Tournament(IConfront confront)
        {
            Confront = confront;
        }
        public IPlayer FindWinner(JArray array)
        {
            return FindWinner(ConvertJArrayToPlayerList(array));
        }

        private List<object> ConvertJArrayToPlayerList(JArray array)
        {
            List<object> list = new List<object>();
            object firstElement = array[0];
            if (!(firstElement is JArray))
            {
                string name = array[0].ToString();
                string command = array[1].ToString();
                IPlayer player = new Player(name, command);

                list.Add(player);

                return list;
            }
            foreach (JArray innerArray in array)
            {
                List<object> innerList = ConvertJArrayToPlayerList(innerArray);
                list.Add(innerList.Count == 1 ? innerList[0] : innerList);
            }

            return list;
        }


        //recebe Lista multidimencional de IPlayer e retorna o Vencedor do torneio
        public IPlayer FindWinner(IList playerList)
        {
            if (playerList.Count == 0)
            {
                throw new Exception("List can't be empty on rpsGameWinner");
            }

            while (true) {
                object firstElement = playerList[0];
                if (firstElement is IPlayer)
                {
                    IPlayer winner = Confront.FindWinner(playerList[0] as IPlayer, playerList[1] as IPlayer);
                    Console.WriteLine('p');
                    Console.WriteLine(winner);
                    return winner;
                }

                for (var i = 0; i < playerList.Count; i++)
                {
                    IList innerList = playerList[i] as IList;
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

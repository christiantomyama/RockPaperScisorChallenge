using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using RockPaperScissor.Domain.Exceptions;
using RockPaperScissor.Domain.Interfaces;

namespace RockPaperScissor.Domain.Tournament
{
    public class Tournament
    {
        public int NUMBER_OF_PLAYERS = 2;
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
            if (playerList.Count != NUMBER_OF_PLAYERS)
            {
                throw new WrongNumberOfPlayersError(playerList.Count);
            }

            while (true) {
                object firstElement = playerList[0];
                object secondElement = playerList[1];
                if (firstElement is IPlayer && secondElement is IPlayer)
                {
                    IPlayer winner = Confront.FindWinner(firstElement as IPlayer, secondElement as IPlayer);
                    Console.WriteLine('p');
                    Console.WriteLine(winner);
                    return winner;
                }

                for (var i = 0; i < playerList.Count; i++)
                {
                    if (playerList[i] is IPlayer)
                    {
                        continue;
                    }
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

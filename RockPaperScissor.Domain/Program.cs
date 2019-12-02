using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;

namespace RockPaperScissor.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<List<Player>> list = new List<List<Player>>()
             List<object> list = new List<object>()
             {
                //new List<object>()
                //{
                //    new Player("ASDA", 'R'),
                //    new Player("QWEQ", 'R'),
                //},
                //new List<object>()
                //{
                //    new Player("asda", 'R'),
                //    new Player("qwer", 'R'),
                //}

            };
            List<object> ll = new List<object>()
            {
                new string[]{"asda", "R" },
                new string[]{"qwer", "R" },
            };
            Console.WriteLine(ll[0] is string[]);

            new RpsConfront();
            return;
            //test(list);
        }

        static void test(List<object> list)
        {
            Console.WriteLine(list is List<object>);
            foreach (object item in list)
            {
                Console.WriteLine(item is IList);
            }
        }

    }
}

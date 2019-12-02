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
             List<object> list = new List<object>()
             {
                //new List<object>()
                //{
                //    new Player("ASDA", "R"),
                //    new Player("QWEQ", "R"),
                //},
                //new List<object>()
                //{
                //    new Player("asda", "R"),
                //    new Player("qwer", "R"),
                //}

            };
            List<object> ll = new List<object>()
            {
                new string[]{"asda", "R" },
                new string[]{"qwer", "R" },
            };

            new RpsConfront();
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {

        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {

        }
    }
}
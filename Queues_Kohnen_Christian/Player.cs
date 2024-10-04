﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues_Kohnen_Christian
{
    internal class Player
    {
        public int Health { get; set; }
        public string GamerTag { get; }
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Games game, Queue<Player> queue)
        {
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()
        {
            return GamerTag;
        }
    }
}

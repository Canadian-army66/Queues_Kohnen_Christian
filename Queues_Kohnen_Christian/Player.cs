using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues_Kohnen_Christian
{
    internal class Player
    {
        public int Health { get; set; }                         //creates an automatic getter and setter
        public string GamerTag { get; }                         //creates an automatic getter
        public Player(int healthParam, string nameParam)        //creates a constructor with health and name parameters
        {
            Health = healthParam;                               //assigns health and gamertag to their respective parameters
            GamerTag = nameParam;
        }

        public void JoinGame(Games game, Queue<Player> queue)   //creates a JoinGame method that uses the game and queue parameter
        {
            if(game.CurrentPlayers == game.MaxPlayers)          //if the curren tplayers are equal to the max players, it adds 'this' to the player queue
            {
                queue.Enqueue(this);
            }
            else                                                //otherwise it prints "join game" and adds the current player
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()                       //creates an override that returns a gamertag
        {
            return GamerTag;
        }
    }
}

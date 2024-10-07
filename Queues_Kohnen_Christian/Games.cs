using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues_Kohnen_Christian
{
    internal class Games
    {
        public int MaxPlayers { get; }                          //makes an automatic getter
        public int CurrentPlayers { get; set; }                 //makes an automatic getter and setter

        public Games(int manP, int currentP)                    //creates a constructor for manP and currentP
        {
            MaxPlayers = manP;                                  //asigns MaxPlayer to the manP parameter
            CurrentPlayers = currentP;                          //assigns CurrentPlayers to currentP parameter
        }

        public void KickPlayer()                                //creates the KickPlayer method which removes one player 
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue)       //makes a CheckQueue method that uses the Queue<player> parameter
        {
            if(CurrentPlayers < MaxPlayers)                     //if the number of current players is less than the max payers...
            {
                if(playerQueue.Count > 0)                       //and if the number of players in queue is greater than zero, it calls a dequeue and adds the number of players
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else                                            //otherwise, say that there is no players online
                {
                    Console.WriteLine("No Players Online!");
                }
            }
        }
    }
}

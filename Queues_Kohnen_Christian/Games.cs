using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues_Kohnen_Christian
{
    internal class Games
    {
        public int MaxPlayers { get; }
        public int CurrentPlayers { get; set; }

        public Games(int manP, int currentP)
        {
            MaxPlayers = manP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No Players Online!");
                }
            }
        }
    }
}

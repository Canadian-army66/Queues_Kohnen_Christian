using System;

namespace Queues_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Games myGame = new Games(50, 49);                       //creates a game object that has a max player count of 50 and the current players 49
            Queue<Player> waitinfToJoinQ = new Queue<Player>();     //creates a queue for player objects
            
            //creates player objects
            Player p1 = new Player(100, "XX_BrickGamer_XX");
            Player p2 = new Player(100, "GamerZ67");
            Player p3 = new Player(100, "BombasticLion_6752");
            Player p4 = new Player(100, "Mike2001");

            //calls JoinGame for the players
            p1.JoinGame(myGame, waitinfToJoinQ);
            p2.JoinGame(myGame, waitinfToJoinQ);
            p3.JoinGame(myGame, waitinfToJoinQ);
            p4.JoinGame(myGame, waitinfToJoinQ);

            Console.WriteLine("Players in the queue:");             //prints title for the queue
            foreach(Player player in waitinfToJoinQ)                //for each player in the queue, it prints their gamertag
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();                                    //calls KickPlayer method

            myGame.CheckQueue(waitinfToJoinQ);                      //checks the queue

            Console.WriteLine("\nPlayers in the queue:");           //prints title for the queue
            foreach (Player player in waitinfToJoinQ)               //for each player in the queue, it prints their gamertag
            {
                Console.WriteLine(player);
            }
        }
    }
}
using System;

namespace Queues_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Games myGame = new Games(50, 49);
            Queue<Player> waitinfToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "XX_BrickGamer_XX");
            Player p2 = new Player(100, "GamerZ67");
            Player p3 = new Player(100, "BombasticLion_6752");
            Player p4 = new Player(100, "Mike2001");

            p1.JoinGame(myGame, waitinfToJoinQ);
            p2.JoinGame(myGame, waitinfToJoinQ);
            p3.JoinGame(myGame, waitinfToJoinQ);
            p4.JoinGame(myGame, waitinfToJoinQ);

            Console.WriteLine("Players in the queue:");
            foreach(Player player in waitinfToJoinQ)
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();

            myGame.CheckQueue(waitinfToJoinQ);

            Console.WriteLine("\nPlayers in the queue:");
            foreach (Player player in waitinfToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}
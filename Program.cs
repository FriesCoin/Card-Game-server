using System;

namespace Card_Game_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Servers";

            Server.Start(50, 26950);

            Console.ReadKey();
        }
    }
}

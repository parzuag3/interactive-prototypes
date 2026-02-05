using System;

namespace class11142022
{
    class Program
    {
        static void Main(string[] args)
        {
            Tunnel tunnelObj = new Tunnel();
            tunnelObj.PrintTunnel();

            Player playerObj = new Player('@', 4);
            tunnelObj.tunnel[playerObj.PlayerIndex] = playerObj.player;
            tunnelObj.PrintTunnel();

            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    if (playerObj.PlayerIndex < 0 || tunnelObj.tunnel[playerObj.PlayerIndex - 1] != ' ')
                        continue;
                    playerObj.PlayerIndex--;
                    playerObj.MoveLeft(tunnelObj.tunnel);
                    tunnelObj.PrintTunnel();

                }
                if (input.Key == ConsoleKey.RightArrow)
                {
                    if (playerObj.PlayerIndex < 0 || tunnelObj.tunnel[playerObj.PlayerIndex + 1] != ' ')
                        continue;
                    playerObj.PlayerIndex++;
                    playerObj.MoveRight(tunnelObj.tunnel);
                    tunnelObj.PrintTunnel();

                }
            }



        }
    }
}
    


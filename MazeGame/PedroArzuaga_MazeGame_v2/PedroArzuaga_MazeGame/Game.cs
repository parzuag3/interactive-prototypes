using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PedroArzuaga_MazeGame
{
    class Game
    {
        private Maze MyMaze;
        private Player CurrentPlayer;
        public void Start()
        {
            

            

            string[,] grid = {
            { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
            { "#", "S", "#", "#", "#", "#", " ", " ", " ", "#"},
            { "#", " ", " ", " ", " ", " ", " ", "#", "#", "#"},
            { "#", "#", " ", "#", " ", "#", " ", "#", "F", "#"},
            { "#", "#", "#", "#", " ", "#", " ", "#", " ", "#"},
            { "#", "#", " ", " ", " ", "#", " ", "#", " ", "#"},
            { "#", "#", " ", "#", "#", "#", "#", "#", " ", "#"},
            { "#", "#", " ", " ", " ", " ", "#", " ", " ", "#"},
            { "#", "#", "#", "#", "#", " ", " ", " ", "#", "#"},
            { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
            };
            MyMaze = new Maze(grid);
            

            CurrentPlayer = new Player(1, 1);



            RunGameLoop();
        }

        private void DrawFrame()
        {
            Clear();
            MyMaze.Draw();
            CurrentPlayer.Draw();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyMaze.MoveTo(CurrentPlayer.X, CurrentPlayer.Y - 1))
                        {
                        CurrentPlayer.Y -= 1;
                    }
                    
                    break;
                case ConsoleKey.DownArrow:
                    if (MyMaze.MoveTo(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyMaze.MoveTo(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyMaze.MoveTo(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void RunGameLoop()
        {
            while(true)
            {
                DrawFrame();

                HandlePlayerInput();

                System.Threading.Thread.Sleep(20);
            }
        }
    }
}

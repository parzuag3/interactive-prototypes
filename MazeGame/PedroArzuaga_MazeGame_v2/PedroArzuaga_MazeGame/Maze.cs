using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PedroArzuaga_MazeGame
{
    class Maze
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;

        public Maze(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }

        }

        public bool MoveTo(int x, int y)
        {
            if (x < 0 || y < 0 ||  x>= Cols || y >= Rows)
                {
                return false;
            }

            return Grid[y, x] == " " || Grid[y, x] == "F";
        }
    }

}

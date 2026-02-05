using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Player { PLAYER_1 = 'X', PLAYER_2 = 'O' };
    internal class TicTacToe
    {
        private const int BOARD_SIZE = 3;
        private char[,] board;
        

        public TicTacToe()
        {
            board = new char[BOARD_SIZE, BOARD_SIZE];

            reset();
        }

        public bool isBoardFull()
        {
            for (int i = 0; i < BOARD_SIZE; ++i)
            {
                for (int j = 0; j < BOARD_SIZE; ++j)
                {
                    if (board[i,j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool isGameWon(Player player)
        {
            if (CheckWinHorizX() || CheckWinVerticalX() || CheckWinDiagX())
            {
                player = Player.PLAYER_1;
                return true;
            }
            else if (CheckWinHorizO() || CheckWinVerticalO() || CheckWinDiagO())
            {
                player = Player.PLAYER_2;
                return true;
            }
            else if (isBoardFull())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckWinHorizX()
        {
            if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
            {
                return true;
            }
            else if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                return true;
            }
            else if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinHorizO()
        {
            if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
            {
                return true;
            }
            else if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
            {
                return true;
            }
            else if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckWinVerticalX()
        {
            if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }
            else if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
            {
                return true;
            }
            else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinVerticalO()
        {
            if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
            {
                return true;
            }
            else if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
            {
                return true;
            }
            else if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinDiagX()
        {
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinDiagO()
        {
            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setPlayerMove(ref Player player, int row, int col) 
        {
            if (player == Player.PLAYER_1)
                player = Player.PLAYER_2;
            else
                player = Player.PLAYER_1;

            board[row-1, col-1] = (char)player;
        }
        public void reset() 
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    board[i, j] = ' ';
                }
            }
        }

    }
}

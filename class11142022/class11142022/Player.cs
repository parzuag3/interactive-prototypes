using System;
using System.Collections.Generic;
using System.Text;

namespace class11142022
{
    class Player
    {
        public char player;
        private int playerIndex;
        public int PlayerIndex
        {
            get { return playerIndex; }
            set { this.playerIndex = value; }
        }

        public Player()
        {
            this.player = '$';
            this.playerIndex = 4;
        }

        public Player(char playerSymbol, int playerPosition)
        {
            this.player = playerSymbol;
            this.playerIndex = playerPosition;
        }

        public void MoveLeft(char[] array)
        {
            array[playerIndex + 1] = ' ';
            array[playerIndex] = player;
        }
        public void MoveRight(char[] array)
        {
            array[playerIndex - 1] = ' ';
            array[playerIndex] = player;
        }
    }
}

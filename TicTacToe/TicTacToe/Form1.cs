using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private TicTacToe game;
        public Form1()
        {
            InitializeComponent();
            game = new TicTacToe();
        }
        private Player player = Player.PLAYER_1;


        private void button_click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            button.Text = String.Format("{0}", (char)player);
            
            if (button.Name == "A1")
            {
                game.setPlayerMove(ref player, 1, 1);
            }
            else if (button.Name == "A2")
            {
                game.setPlayerMove(ref player, 2, 1);
            }
            else if (button.Name == "A3")
            {
                game.setPlayerMove(ref player, 3, 1);
            }
            else if (button.Name == "B1")
            {
                game.setPlayerMove(ref player, 1, 2);
            }
            else if (button.Name == "B2")
            {
                game.setPlayerMove(ref player, 2, 2);
            }
            else if (button.Name == "B3")
            {
                game.setPlayerMove(ref player, 3, 2);
            }
            else if (button.Name == "C1")
            {
                game.setPlayerMove(ref player, 1, 3);
            }
            else if (button.Name == "C2")
            {
                game.setPlayerMove(ref player, 2, 3);
            }
            else if (button.Name == "C3")
            {
                game.setPlayerMove(ref player, 3, 3);
            }
            button.Enabled = false;

            if (game.isBoardFull())
            {
                MessageBox.Show("Game is a draw!", "Game Status");
            }
            else if (game.isGameWon(player))
            {
                MessageBox.Show($"{player} Won", "Game Status");
                disableAllButtons();
            }
        }

        private void disableAllButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

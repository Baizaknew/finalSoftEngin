using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors_game
{
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();
        }

        // images
        Bitmap rock = Properties.Resources.rock;
        Bitmap paper = Properties.Resources.paper;
        Bitmap scissors = Properties.Resources.scissors;
        Bitmap random_picture;

        // wins
        int player_wins = 0, computer_wins = 0;
        // a list of images
        ArrayList list = new ArrayList();
        // random to get a random image
        Random random = new Random();

        private void Game_Form_Load(object sender, EventArgs e)
        {
            pictureBoxRock.Image = Properties.Resources.rock;
            pictureBoxPaper.Image = Properties.Resources.paper;
            pictureBoxScissors.Image = Properties.Resources.scissors;

            // add images to the list
            list.Add(rock);
            list.Add(paper);
            list.Add(scissors);
        }

        private void pictureBoxRock_Click(object sender, EventArgs e)
        {
            // display rock image
            pictureBox_player.Image = rock;
            // get random image
            random_picture = (Bitmap)list[random.Next(list.Count)];
            // display the random image
            pictureBox_computer.Image = random_picture;
            // get the winner
            getWinner(rock, random_picture);
        }

        private void pictureBoxPaper_Click(object sender, EventArgs e)
        {
            // display paper image
            pictureBox_player.Image = paper;
            // get random image
            random_picture = (Bitmap)list[random.Next(list.Count)];
            // display the random image
            pictureBox_computer.Image = random_picture;
            // get the winner
            getWinner(paper, random_picture);
        }

        private void pictureBoxScissors_Click(object sender, EventArgs e)
        {
            // display rock image
            pictureBox_player.Image = scissors;
            // get random image
            random_picture = (Bitmap)list[random.Next(list.Count)];
            // display the random image
            pictureBox_computer.Image = random_picture;
            // get the winner
            getWinner(scissors, random_picture);
        }


        // create a function to get the winner
        public void getWinner(Bitmap player, Bitmap computer)
        {
            if (player.Equals(computer))
            {
                // it's a draw - the same image
            }
            else if (player.Equals(rock))
            {
                if (computer.Equals(scissors))
                {
                    player_wins++;
                    label_PlayerWins.Text = player_wins.ToString();
                }
                else
                {
                    computer_wins++;
                    label_ComputerWins.Text = computer_wins.ToString();
                }
            }
            else if (player.Equals(paper))
            {
                if (computer.Equals(rock))
                {
                    player_wins++;
                    label_PlayerWins.Text = player_wins.ToString();
                }
                else
                {
                    computer_wins++;
                    label_ComputerWins.Text = computer_wins.ToString();
                }
            }
            else if (player.Equals(scissors))
            {
                if (computer.Equals(paper))
                {
                    player_wins++;
                    label_PlayerWins.Text = player_wins.ToString();
                }
                else
                {
                    computer_wins++;
                    label_ComputerWins.Text = computer_wins.ToString();
                }
            }

        }

    }
}

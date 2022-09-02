using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objektWinFormsZaidimas.Characters;

namespace objektWinFormsZaidimas
{
    public partial class charCreation : Form
    {

        public charCreation()

        {
            InitializeComponent();
        }

        private void selectClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void charCreation_Load(object sender, EventArgs e)
        {
            selectClass.SelectedIndex = 0;
            statPointsLeft.Text = "20";
            selectSTR.Text = "0";
            selectINT.Text = "0";
        }



        private void statPointsLeft_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(statPointsLeft.Text) <= 0)
            {
                MessageBox.Show("No more points left!");
                statPointsLeft.Text = "0";
            }
        }

        private void increaseSTR_Click(object sender, EventArgs e)
        {
            int leftPoints = int.Parse(statPointsLeft.Text);
            if (leftPoints > 0)
            {
                int STR = int.Parse(selectSTR.Text);
                STR++;
                selectSTR.Text = STR.ToString();
                leftPoints = int.Parse(statPointsLeft.Text);
                leftPoints--;
                statPointsLeft.Text = leftPoints.ToString();
            }
        }

        private void decreaseSTR_Click(object sender, EventArgs e)
        {
            int leftPoints = int.Parse(statPointsLeft.Text);
            if (leftPoints < 20)
            {
                int STR = int.Parse(selectSTR.Text);
                STR--;
                selectSTR.Text = STR.ToString();
                leftPoints = int.Parse(statPointsLeft.Text);
                leftPoints++;
                statPointsLeft.Text = leftPoints.ToString();
            }
        }

        private void increaseINT_Click(object sender, EventArgs e)
        {
            int leftPoints = int.Parse(statPointsLeft.Text);
            if (leftPoints > 0)
            {
                int INT = int.Parse(selectINT.Text);
                INT++;
                selectINT.Text = INT.ToString();
                leftPoints = int.Parse(statPointsLeft.Text);
                leftPoints--;
                statPointsLeft.Text = leftPoints.ToString();
            }
        }

        private void decreaseINT_Click(object sender, EventArgs e)
        {
            int leftPoints = int.Parse(statPointsLeft.Text);
            if (leftPoints < 20)
            {
                int INT = int.Parse(selectINT.Text);
                INT--;
                selectINT.Text = INT.ToString();
                leftPoints = int.Parse(statPointsLeft.Text);
                leftPoints++;
                statPointsLeft.Text = leftPoints.ToString();
            }
        }

        private void selectSTR_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(selectSTR.Text) <= 0)
            {
                selectSTR.Text = "0";
                decreaseSTR.Enabled = false;
            }
            else
            {
                decreaseSTR.Enabled = true;
            }
        }

        private void selectINT_TextChanged(object sender, EventArgs e)
        {

            if (int.Parse(selectINT.Text) <= 0)
            {
                selectINT.Text = "0";
                decreaseINT.Enabled = false;
            }
            else
            {
                decreaseINT.Enabled = true;
            }
        }
        public Player newPlayer = new Player();

        string enemyName;
        private void beginGame_Click(object sender, EventArgs e)
        {
            if (enterPlayerName.TextLength == 0)
            {
                MessageBox.Show("Please enter your name!", "Turn-based game");
            }
            else
            {
                Random rnd = new Random();
                Entity.attackCount = 0;
                //Chooses a random enemy from two choices
                int enemyGenerate = rnd.Next(0, 2);

                switch (enemyGenerate)
                {
                    case 0:
                        enemyName = "Dragon";
                        break;

                    case 1:
                        enemyName = "Orc";
                        break;

                }

                if (selectClass.SelectedIndex == 0)
                {
                    combatScreenWarrior warScr = new combatScreenWarrior(enterPlayerName.Text.ToString(), int.Parse(selectSTR.Text), int.Parse(selectINT.Text), enemyName);
                    warScr.Show();
                }

                else if (selectClass.SelectedIndex == 1)
                {
                    combatScreenMage mageScr = new combatScreenMage(enterPlayerName.Text.ToString(), int.Parse(selectSTR.Text), int.Parse(selectINT.Text), enemyName);
                    mageScr.Show();
                }
            }
        }
    }


}

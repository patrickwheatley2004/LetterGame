using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Patrick Wheatley 22/08/2022
// Letter Game
namespace lettergame
{
    public partial class frmLetterGame : Form
    {
        public frmLetterGame()
        {
            InitializeComponent();
        }
        // Setting up global variables, game mode default is classic.
        string gamemode = "Classic";
        string gamemodifier = "none";
        int lives = 999;
        double time = 30;
        int combo = 0;
        int points = 0;
        bool hiddenTimer = false;

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            // textbox, where the user inputs.
            if (txtText.Text.Length == txtText.MaxLength)
            {
                checkInput(txtText.Text);
            }
            txtText.Clear();
            txtText.Focus();
        }

        private void endGame()
        {
            // ends the game.
            gameTime.Stop();
            combo = 0;
            points = 0;
            txtText.Enabled = false;
            MessageBox.Show("GAME OVER");
            btnClassic.Enabled = true;
            btnInfinite.Enabled = true;
            btnSuddenDeath.Enabled = true;
            btnLives.Enabled = true;
            btnHideTimer.Enabled = true;
            btnStart.Enabled = true;
        }

        private void checkLives()
        {
            // checking lives.
            if (lives <= 0)
            {
                endGame();
            }
        }

        private void checkInput(string input)
        {
            // checking input. If the input is corrct, combo and points increase, a new letter is chosen.
            // if the input is incorrect the combo resets but points stay the same, if the game mode involves lives the lives go down by 1.
            input = input.ToUpper();
            if (input == lblChar.Text)
            {
                combo++;
                points++;
                if (gamemode == "Infinite")
                {
                    time = 2;
                }
                changeLetter();
            }
            else
            {
                combo = 0;
                if (gamemodifier != "none")
                {
                    lives--;
                }
            }
            checkLives();
            lblCombo.Text = "Combo: " + combo.ToString();
            lblPoints.Text = "Points: " + points.ToString();
            if (lives > 10)
            {
                lblLives.Text = "Lives: INF";
            }
            else
            {
                lblLives.Text = "Lives: " + lives;
            }
            lblTime.Text = "Time: " + time;

        }

        private void changeLetter()
        {
            // selecting a random letter when the game starts / correct user input.
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random randy = new Random();
            int num = randy.Next(0, letters.Length);
            lblChar.Text = letters[num];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // initializing settings in-case the user doesn't change settings when they just finished the game.
            if (gamemode == "Classic")
            {
                lives = 99999;
                time = 30;
            }
            else if (gamemode == "Infinite")
            {
                lives = 999999;
                time = 2;
            }

            if (gamemodifier == "Sudden Death")
            {
                lives = 1;
            }
            else if (gamemodifier == "Lives")
            {
                lives = 3;
            }
            changeLetter();
            btnClassic.Enabled = false;
            btnInfinite.Enabled = false;
            btnSuddenDeath.Enabled = false;
            btnLives.Enabled = false;
            btnHideTimer.Enabled = false;
            btnStart.Enabled = false;
            txtText.Enabled = true;
            txtText.Focus();
            gameTime.Start();

        }

        private void updateSettings()
        {
            // showing the user their selected settings.
            if (lives > 10)
            {
                lblSettings.Text = "Settings\nGame Mode: " + gamemode + "\nGame Modifier: " + gamemodifier + "\nLives: INF\nTime: " + time + "\nHide Timer: " + hiddenTimer;
            }
            else
            {
                lblSettings.Text = "Settings\nGame Mode: " + gamemode + "\nGame Modifier: " + gamemodifier + "\nLives: " + lives + "\nTime: " + time + "\nHide Timer: " + hiddenTimer;
            }
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            gamemode = "Classic";
            btnClassic.ForeColor = Color.DarkGreen;
            btnInfinite.ForeColor = Color.Black;
            time = 30;
            lblTime.Text = "Time: " + time.ToString();
            updateSettings();
        }

        private void btnInfinite_Click(object sender, EventArgs e)
        {
            gamemode = "Infinite";
            btnClassic.ForeColor = Color.Black;
            btnInfinite.ForeColor = Color.DarkGreen;
            time = 2;
            lblTime.Text = "Time: " + time.ToString();
            lblSettings.Text = "Settings\nGame Mode: " + gamemode + "\nGame Modifier: " + gamemodifier;
            updateSettings();
        }

        private void btnSuddenDeath_Click(object sender, EventArgs e)
        {
            if (gamemodifier != "Sudden Death")
            {
                gamemodifier = "Sudden Death";
                btnSuddenDeath.ForeColor = Color.DarkGreen;
                btnLives.ForeColor = Color.Black;
                lives = 1;
                lblLives.Text = "Lives: " + lives.ToString();
            }
            else
            {
                gamemodifier = "none";
                btnSuddenDeath.ForeColor = Color.Black;
                lblLives.Text = "Lives: INF";
                lives = 999999999;
            }
            updateSettings();
        }

        private void btnLives_Click(object sender, EventArgs e)
        {
            if (gamemodifier != "Lives")
            {
                gamemodifier = "Lives";
                btnSuddenDeath.ForeColor = Color.Black;
                btnLives.ForeColor = Color.DarkGreen;
                lives = 3;
                lblLives.Text = "Lives: " + lives.ToString();
            }
            else
            {
                gamemodifier = "none";
                btnLives.ForeColor = Color.Black;
                lblLives.Text = "Lives: INF";
                lives = 55;
            }
            updateSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loading
            txtText.Enabled = false;
            btnClassic_Click(sender, e);
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            // game time decreases.
            time = time - 0.01;
            lblTime.Text = "Time: " + time;
            if (time <= 0)
            {
                endGame();
            }
        }

        private void btnHideTimer_Click(object sender, EventArgs e)
        {
            if (hiddenTimer == false)
            {
                btnHideTimer.ForeColor = Color.DarkGreen;
                hiddenTimer = true;
                lblTime.Visible = false;
            }
            else
            {
                btnHideTimer.ForeColor = Color.Black;
                hiddenTimer = false;
                lblTime.Visible = true;
            }
            updateSettings();
        }
    }
}

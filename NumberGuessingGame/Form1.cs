namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<Label> lblResults = new List<Label> ();
        List<PictureBox> picResults = new List<PictureBox> ();

        int answer = 0;
        int numGuess = 0;
        int intRandomMax = 0;

        private void InitializeGame()
        {
            lblResults.Add(label1);
            lblResults.Add(label2);
            lblResults.Add(label3);
            lblResults.Add(label4);
            lblResults.Add(label5);

            picResults.Add(pictureBox1);
            picResults.Add(pictureBox2);
            picResults.Add(pictureBox3);
            picResults.Add(pictureBox4);
            picResults.Add(pictureBox5);
        }

        private void ResetGame()
        {
            foreach (Label label in lblResults)
            {
                label.Text = "";
            }

            foreach (PictureBox picture in picResults)
            {
                picture.Image = null;
            }

            txtGuess.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Text = "START";
            numGuess = 0;
        }

        private void StartGame()
        {
            answer = random.Next(1, intRandomMax + 1);
            txtGuess.Enabled = true;
            btnStart.Text = "RESET";
        }

        private void GameWon()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("Game Won!");
        }

        private void GameLost()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("Game Lost!");
        }

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                StartGame();
            }
            else
            {
                ResetGame();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbEasy = (RadioButton)sender;
            if (rbEasy.Checked)
            {
                intRandomMax = 10;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbMedium = (RadioButton)sender;
            if (rbMedium.Checked)
            {
                intRandomMax = 25;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbHard = (RadioButton)sender;
            if (rbHard.Checked)
            {
                intRandomMax = 50;
            }
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = txtGuess.Text;
                int guess = int.Parse(text);
                if (guess == answer)
                {
                    lblResults[numGuess].Text = "Correct";
                    lblResults[numGuess].ForeColor = Color.Green;
                    picResults[numGuess].Image = Properties.Resources.correct_icon;
                    GameWon();
                }
                else
                {
                    string highLow = guess > answer ? "Too High" : "Too Low";
                    lblResults[numGuess].Text = highLow;
                    lblResults[numGuess].ForeColor = Color.Red;
                    picResults[numGuess].Image = Properties.Resources.incorrect_icon;
                    if (numGuess >= 4)
                    { 
                        GameLost();
                    }
                }
                numGuess++;
            }
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
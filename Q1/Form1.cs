using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        GuessNumber game;
        public Form1()
        {
            InitializeComponent();
            FormInitialization();
		}

        private void FormInitialization()
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

			game = new GuessNumber();
			game.NewGame();
			lblAnswer.Text = game.Answer;
		}

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.NewGame();
            lblAnswer.Text = game.Answer;
            txtShow.Text = string.Empty;
            txtInput.Text = string.Empty;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
				string show = game.Guess(txtInput.Text);
				txtShow.Text = show;
				txtInput.Text = String.Empty;
				if (show.EndsWith("4A0B\r\n")) MessageBox.Show("Good!", "Correct",
																MessageBoxButtons.OK,
																MessageBoxIcon.Information);
			}
            catch (Exception ex)
            {
				txtInput.Text = String.Empty;
				MessageBox.Show(ex.Message, "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
		}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			FormaInitialization();
		}

		private void FormaInitialization()
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;

			txtDigit0.ReadOnly = true;
			txtDigit1.ReadOnly = true;
			txtDigit2.ReadOnly = true;
			txtDigit3.ReadOnly = true;
			txtDigit0.TextAlign = HorizontalAlignment.Center;
			txtDigit1.TextAlign = HorizontalAlignment.Center;
			txtDigit2.TextAlign = HorizontalAlignment.Center;
			txtDigit3.TextAlign = HorizontalAlignment.Center;

			lblValue.Visible = false;
		}

		private void btnRoll_Click(object sender, EventArgs e)
		{
			RollDiceGame game = new RollDiceGame();
			ResultValue result = game.Roll();

			txtDigit0.Text = result.DiceNumbers[0].ToString();
			txtDigit1.Text = result.DiceNumbers[1].ToString();
			txtDigit2.Text = result.DiceNumbers[2].ToString();
			txtDigit3.Text = result.DiceNumbers[3].ToString();

			lblValue.Visible = true;
			if (result.DiceValue == -1)
			{
				lblValue.Text = "NoNo!!!";
				MessageBox.Show("Reroll", "Reroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				lblValue.Text = result.DiceValue.ToString();
			}
		}
	}

	public class ResultValue
	{
		public int DiceValue { get; set; }
		public int[] DiceNumbers { get; set; }
	}

	public class RollDiceGame
	{
		public ResultValue result { get; set; }
		public ResultValue Roll()
		{
			result = new ResultValue();
			result.DiceNumbers = GetNumbers();
			result.DiceValue = DiceValue(result.DiceNumbers);

			return result;
		}

		private int[] GetNumbers()
		{
			// Get 4 ramdom numbers
			int[] numbers = new int[4];
			int seed = Guid.NewGuid().GetHashCode();
			Random random = new Random(seed);
			for(int i = 0; i < 4; i++)
			{
				numbers[i] = random.Next(1, 7);
			}
			return numbers;
		}

		private int DiceValue(int[] diceNumbers)
		{
			int[] counts = new int[7];

			int sum = 0;

			// Count 4-digit
			for(int i = 0; i < diceNumbers.Length; i++)
			{
				counts[diceNumbers[i]]++;
				sum += diceNumbers[i];
			}

			int result = -1;
			// Determine
			for(int i = 1; i < counts.Length; i++)
			{
				if (counts[i] == 4 || counts[i] == 3 || counts[i] == 2)
				{
					result = sum - i * 2;
					break;
				}
			}

			return result;
		}
	}
}

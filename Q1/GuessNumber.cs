using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1
{
	public class GuessNumber
    {
        private string answer;
        private string show;
        private int[] answerInformation;
        private int[] guessInformation;


		public string Answer { get { return answer; } }

        public void NewGame()
        {
            answer = GetNumber();

            answerInformation = new int[10];
            // Array Initialization
            ArrayInitialization(answerInformation);

            // Get answer information
            GetInformation(answerInformation, answer);
            show = String.Empty;
		}

        public string Guess(string input)
        {
            // Is value right
            input = IsRight(input);

            guessInformation = new int[10];
            // Array Initialization
			ArrayInitialization(guessInformation);

			// Get input information
			GetInformation(guessInformation, input);

            // Determine XAXB
			int counterA = 0;
            int counterB = 0;
            for (int i = 0; i < answerInformation.Length; i++)
            {
                if (answerInformation[i] != -1 && guessInformation[i] != -1)
                {
                    if (answerInformation[i] == guessInformation[i])
                        counterA++;
                    else
                        counterB++;
                }
            }

			show += $"{input} {counterA}A{counterB}B\r\n";

			return show;
        }

        private void GetInformation(int[] information, string value)
        {
            // 將string資訊填入array中
            for(int i = 0; i < value.Length; i++)
            {
                int integer = (int)char.GetNumericValue(value[i]);
                information[integer] = i;
            }
		}

        private string GetNumber()
        {
            // Initialization array
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            // Get random array
            for (int i = 0; i < numbers.Length; i++)
            {
                // Get random number
				int seed = Guid.NewGuid().GetHashCode();
				Random random = new Random(seed);
                int randomNumber = random.Next(0, 10);

                // swap 
                Swap(ref numbers[i], ref numbers[randomNumber]);
			}

            // return first 4 number
            string result = string.Empty;
            for(int i = 3; i >= 0; i--)
            {
                result += numbers[i].ToString();
            }
            return result;
        }

		private string IsRight(string value)
		{
            // Is less than four
			if (value.Length != 4) throw new Exception("Please input 4-digit number!!");

            // Is not number
			for (int i = 0; i < value.Length; i++)
			{
				int integer = (int)char.GetNumericValue(value[i]);
				if (integer < 0 || integer > 9) throw new Exception("Please Enter number");
			}

            // Is repeat number
            HashSet<char> chars = new HashSet<char>();
            for(int i = 0; i < value.Length; i++)
            {
                chars.Add(value[i]);
            }
            if (chars.Count < 4) throw new Exception("Please enter different number");

			return value;
		}

        private void ArrayInitialization(int[] information)
        {
            for (int i = 0; i < information.Length; i++)
                information[i] = -1;
        }

		private void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}

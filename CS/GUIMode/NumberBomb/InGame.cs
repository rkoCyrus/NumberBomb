using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace NumberBomb
{
    /// <summary>
    /// All main event of this game
    /// </summary>
    public partial class InGame : Form
    {
        /// <summary>
        /// Data for storing user's value
        /// </summary>
        private GameData gd;
        /// <summary>
        /// Range of the number
        /// </summary>
        private int[] range = new int[2]; //0 = min, 1 = max
        /// <summary>
        /// Default text for guider label
        /// </summary>
        private string displayGuide = "Please press the keypad below : ";
        /// <summary>
        /// Check is someone guest "correct" number
        /// </summary>
        private bool soneLose = false;
        /// <summary>
        /// Link list (using link queue) to input digit
        /// </summary>
        private InputList digitInput = new InputList();

        /// <summary>
        /// Initalizing all event of the game
        /// </summary>
        /// <param name="gData">Game data</param>
        public InGame(GameData gData)
        {
            InitializeComponent();
            this.gd = gData;
        }

        private void InGame_Load(object sender, EventArgs e)
        {
            range[0] = 1;
            range[1] = gd.getGameRule()[0];
            smallNum.Text = range[0].ToString();
            bigNum.Text = range[1].ToString();
            guider.Text = displayGuide;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            digitInput.inserting("1");
            inputLock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            digitInput.inserting("2");
            inputLock();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            digitInput.inserting("3");
            inputLock();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            digitInput.inserting("4");
            inputLock();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            digitInput.inserting("5");
            inputLock();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            digitInput.inserting("6");
            inputLock();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            digitInput.inserting("7");
            inputLock();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            digitInput.inserting("8");
            inputLock();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            digitInput.inserting("9");
            inputLock();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            digitInput.inserting("0");
            inputLock();
        }

        /// <summary>
        /// Disable after input 3 digit, also update guider text
        /// </summary>
        private void inputLock()
        {
            if (digitInput.getFilled() >= 3)
            {
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else
            {
                button0.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            guider.Text = displayGuide + digitInput.getDigit();
        }

        /// <summary>
        /// Clear all nodes data
        /// </summary>
        private void wipeNode()
        {
            while (digitInput.getFilled() != 0)
            {
                digitInput.removing();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            wipeNode();
            inputLock();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (digitInput.getFilled() <= 0 || digitInput.getFilled() > 3)
            {
                MessageBox.Show("Please enter valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wipeNode();
                inputLock();
            } 
            else if (int.Parse(digitInput.getDigit()) <= range[0] || int.Parse(digitInput.getDigit()) >= range[1])
            {
                MessageBox.Show("The number is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wipeNode();
                inputLock();
            }
            else
            {
                guider.Text = "Checking your input";
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonEnter.Enabled = false;
                buttonReset.Enabled = false;
                buttonBack.Enabled = false;
                waitResult.Start();
            }
        }

        /// <summary>
        /// Checking does user inputed same number which picked by computer
        /// </summary>
        /// <param name="inputNumber">User's input</param>
        /// <param name="luckyNumber">Computer generated number</param>
        /// <returns>Is the input matched</returns>
        private bool validator(int inputNumber,int luckyNumber)
        {
            return inputNumber == luckyNumber;
        }

        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (soneLose)
            {
                DialogResult replay = MessageBox.Show("Play again?","Number Bomb", MessageBoxButtons.YesNo);
                if (replay == DialogResult.Yes)
                {
                    gd.noNeedReplay(false);
                }
            }
        }

        /// <summary>
        /// Slient and wait until get result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waitResult_Tick(object sender, EventArgs e)
        {
            waitResult.Stop();
            SpeechSynthesizer announcer = new SpeechSynthesizer();
            announcer.SetOutputToDefaultAudioDevice();
            if (validator(int.Parse(digitInput.getDigit()), gd.getGameRule()[1]))
            {
                announcer.Rate = -2;
                announcer.Speak("You lose");
                MessageBox.Show("The \"Lucky number\" is " + gd.getGameRule()[1], "You lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                guider.Text = "The balloon poped!";
                smallNum.Text = bigNum.Text = gd.getGameRule()[1].ToString();
                smallNum.ForeColor = bigNum.ForeColor = Color.Red;
                soneLose = true;
            }
            else
            {
                if (int.Parse(digitInput.getDigit()) < gd.getGameRule()[1])
                {
                    range[0] = int.Parse(digitInput.getDigit());
                }
                else if (int.Parse(digitInput.getDigit()) > gd.getGameRule()[1])
                {
                    range[1] = int.Parse(digitInput.getDigit());
                }
                smallNum.Text = range[0].ToString();
                bigNum.Text = range[1].ToString();
                announcer.Rate = -5;
                announcer.Speak(smallNum.Text + " to " + bigNum.Text);
                MessageBox.Show("The current range is from " + range[0].ToString() + " to " + range[1].ToString(), "You safe");
                guider.Text = displayGuide;
                wipeNode();
                inputLock();
                buttonEnter.Enabled = true;
                buttonReset.Enabled = true;
                buttonBack.Enabled = true;
            }
            announcer.Dispose();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (digitInput.getFilled() > 0)
            {
                digitInput.removing();
            }
            inputLock();
        }
    }
}

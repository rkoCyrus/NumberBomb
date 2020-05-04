using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberBomb
{
    public partial class InGame : Form
    {
        private GameData gd;
        private int[] range = new int[2]; //0 = min, 1 = max
        private string displayGuide = "Please press the keypad below : ";
        private bool soneLose = false;
        private InputList digitInput = new InputList();

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

        private void waitResult_Tick(object sender, EventArgs e)
        {
            waitResult.Stop();
            if (validator(int.Parse(digitInput.getDigit()), gd.getGameRule()[1]))
            {
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
                MessageBox.Show("The current range is from " + range[0].ToString() + " to " + range[1].ToString(), "You safe");
                guider.Text = displayGuide;
                wipeNode();
                inputLock();
                buttonEnter.Enabled = true;
                buttonReset.Enabled = true;
                buttonBack.Enabled = true;
            }
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

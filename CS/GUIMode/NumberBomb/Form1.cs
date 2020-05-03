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
    public partial class Form1 : Form
    {
        private int maxNum, popNum, preNum; //Maxium number, number that pop balloon, previous turn of popNum

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int preLuckNum)
        {
            InitializeComponent();
            this.preNum = preLuckNum;
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            maxNum = 100;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            maxNum = 250;
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            maxNum = 500;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Random luckNum = new Random();
            do
            {
                popNum = luckNum.Next(2, maxNum - 1);
            }
            while (popNum == preNum); //Be fair that the previous number cannot use again
            InGame mainEvent = new InGame(maxNum, popNum);
            mainEvent.Show();
            Close();
        }
    }
}

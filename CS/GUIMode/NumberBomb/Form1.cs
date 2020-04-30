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
        private int maxNum;
        public Form1()
        {
            InitializeComponent();
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
    }
}

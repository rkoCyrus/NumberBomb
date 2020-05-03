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
    public partial class PreGame : Form
    {
        private int maxNum;
        private GameData gd;

        public PreGame(GameData gData)
        {
            InitializeComponent();
            this.gd = gData;
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
            gd.setMax(maxNum);
            gd.forceExit = false;
            this.Close();
        }

        private void PreGame_Load(object sender, EventArgs e)
        {
            maxNum = 100;
            gd.forceExit = true;
        }
    }
}

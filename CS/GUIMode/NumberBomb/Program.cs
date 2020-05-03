using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberBomb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameData gData = new GameData();
            while (true)
            {
                Application.Run(new PreGame(gData));
                if (!gData.forceExit)
                {
                    Application.Run(new InGame(gData));
                } 
                else
                {
                    break;
                }
                if (!gData.endGame())
                {
                    int preLuck = gData.getGameRule()[1];
                    gData = new GameData(preLuck);
                } 
                else
                {
                    break;
                }
            }
        }
    }
}

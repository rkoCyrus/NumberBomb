using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBomb
{
    /// <summary>
    /// A platform for transfering data between different form
    /// </summary>
    public class GameData
    {
        private int preLuck, max, luck;
        private bool isGameEnd = true;
        public bool forceExit = true;
        private Random genNum = new Random();

        public GameData()
        {
            this.preLuck = 0;
            this.max = 0;
            getLuckNum();
        }

        public GameData(int lastLuckyNum)
        {
            this.preLuck = lastLuckyNum;
            this.max = 0;
            getLuckNum();
        }

        private void getLuckNum()
        {
            do
            {
                luck = genNum.Next();
            } 
            while (luck==preLuck||luck<=1);
        }

        public void setMax(int maxNum)
        {
            while ((luck%maxNum)<=1)
            {
                getLuckNum();
            }
            this.max = maxNum;
            this.luck %= maxNum;
        }

        /// <summary>
        /// Get maxium number and lucky number
        /// </summary>
        /// <returns>[0] = maxium, [1] = luck</returns>
        public int[] getGameRule()
        {
            int[] gameRule = { max, luck };
            return gameRule;
        }

        public void noNeedReplay(bool yn)
        {
            this.isGameEnd = yn;
        }

        public bool endGame()
        {
            return isGameEnd;
        }
    }
}

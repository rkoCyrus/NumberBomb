using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBomb
{
    public class InputList
    {
        /// <summary>
        /// Header of the nodes
        /// </summary>
        private InputNode flag;
        /// <summary>
        /// Tail of the node
        /// </summary>
        private InputNode root;
        /// <summary>
        /// Counting how many node filled digit
        /// </summary>
        private int filled;
        /// <summary>
        /// Maxium slot for link queue, I think 10 digits are enough unless you want to expand more redicliously
        /// </summary>
        private static readonly int MAXSLOT = 10;

        public InputList()
        {
            flag = null;
            root = null;
            filled = 0;
        }

        /// <summary>
        /// Check does nothining inside of the node
        /// </summary>
        /// <returns>If all node is null, return true. Otherwise, false</returns>
        public bool noList()
        {
            return (flag == null);
        }

        /// <summary>
        /// Get number of filled list
        /// </summary>
        /// <returns></returns>
        public int getFilled()
        {
            return filled;
        }

        /// <summary>
        /// Add data in a node (Do nothing if reached MAXSLOT)
        /// </summary>
        /// <param name="digitInput">Input digit</param>
        public void inserting(Object digitInput)
        {
            if (filled >= MAXSLOT)
            {
                return;
            }
            filled++;
            if (noList())
            {
                flag = root = new InputNode(digitInput);
            }
            else
            {
                root.follow = new InputNode(digitInput);
                root = root.follow;
            }
        }

        /// <summary>
        /// Remove node data
        /// </summary>
        public void removing()
        {
            if (noList())
            {
                return;
            }
            filled--;
            if (flag==root)
            {
                flag = root = null;
            }
            else
            {
                InputNode hand = flag;
                while (hand.follow!=root)
                {
                    hand = hand.follow;
                }
                root = hand;
                root.follow = null;
            }
        }
        
        /// <summary>
        /// Return digit
        /// </summary>
        /// <returns>Digit in string</returns>
        public string getDigit()
        {
            string temp = "";
            InputNode nodeReader = flag;
            while (nodeReader != null)
            {
                temp += nodeReader.digit;
                nodeReader = nodeReader.follow;
            }
            return temp;
        }
    }
}

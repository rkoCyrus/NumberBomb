using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBomb
{
    public class InputNode
    {
        public Object digit;
        public InputNode follow;

        public InputNode(Object data)
        {
            this.digit = data;
            this.follow = null;
        }

        public InputNode(Object data, InputNode next)
        {
            this.digit = data;
            this.follow = next;
        }
    }
}

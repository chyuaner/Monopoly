using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Monopoly
{
    class Block
    {
        protected Point position;

        public Block()
        {
            position = new Point(0, 0);
        }

        public Point Position
        {
            get { return position;}
            set { position = value;}
        }

        public virtual string execute(Player p);
    }
}

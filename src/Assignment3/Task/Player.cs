using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class Player
    {
        public string Name { get; private set; }
        public int Value { get; set; }

        public Player(string name)
        {

            Name = name;
        }

        public abstract int Toss();
        public abstract void PlayerMove(int number);
        public abstract void PlayerMinus();
        public abstract void PlayerPlus();
    }
}
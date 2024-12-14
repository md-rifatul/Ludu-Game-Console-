using Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Task;

namespace Task
{
    public class Computer : Player
    {
        public Computer(string name) : base(name)
        {
        }

        public override void PlayerMinus()
        {
            Value = Value - 52;
        }

        public override void PlayerMove(int number)
        {
            Value += number;
        }

        public void Defould()
        {
            Value = 27;
        }

        public override void PlayerPlus()
        {
            Value += 31;
        }

        public override int Toss()
        {
            return new RandomNumber().Generate();
        }
    }
}
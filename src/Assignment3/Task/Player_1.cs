using Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace Task

{
    public class Player1 : Player

    {
        public Player1(string name) : base(name)
        {
        }

        public override void PlayerMinus()
        {
            Value -= 52;
        }

        public override void PlayerMove(int number)
        {
            Value += number;
        }

        public override void PlayerPlus()
        {
            Value += 31;
        }

        public void Defould()
        {
            Value = 0;
        }

        public override int Toss()
        {
            return new RandomNumber().Generate();
        }
    }
}
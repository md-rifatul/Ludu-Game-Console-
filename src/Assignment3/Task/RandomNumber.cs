using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task

{
    public class RandomNumber
    {
        public int Generate()
        {
            return int.Parse(new Random().Next(1, 7).ToString());
        }
    }
}
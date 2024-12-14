using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class RandomNumberForPlayerMove
    {
        public int Generate()
        {
            return int.Parse(new Random().Next(1, 5).ToString());
        }
    }
}

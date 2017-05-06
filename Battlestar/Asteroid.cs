using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlestar
{
    public class Asteroid
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Random r = new Random();
        public int nextRandom { get; set; }

       public Asteroid()
        {
            Y = 0;
            nextRandom = r.Next(1, 4);
            if(nextRandom == 1)
            {
                X = 29;
            }
            else if(nextRandom == 2)
            {
                X = 173; 
            }
            else 
            {
                X = 319;
            }   
        }
        public void axisY()
        {
            Y = Y + 1;
        }
    }
}

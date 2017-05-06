using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlestar
{
    public class Scene
    {
        public List<Asteroid> asteroidi;

        public Scene()
        {
            asteroidi = new List<Asteroid>();
        }
        internal void generate()
        {
            Asteroid a = new Asteroid();
            asteroidi.Add(a);
            
        }
        internal void remove()
        {
            if (asteroidi.Count > 0)
                asteroidi.RemoveAt(0);
        }

        public void move()
        {
            foreach(Asteroid a in asteroidi)
            {
                a.axisY();
            }
        }
        public void checkHit()
        {
            foreach(Asteroid a in asteroidi)
            {
                if(Form1.left ==true && a.X >= 29 && a.Y >= 207)
                {
                    Form1.stop();
                }
                else if(Form1.right == true && a.X >=319 && a.Y >=207)
                {
                    Form1.stop();
                }
                else
                {
                    if(a.X >=173 && a.Y >= 207)
                    {
                        Form1.stop();
                    }
                }
            }
        }
    }
}

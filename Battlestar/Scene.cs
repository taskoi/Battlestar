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
    }
}

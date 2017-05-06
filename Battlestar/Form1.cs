using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battlestar
{

    public partial class Form1 : Form
    {
        Scene scene;
       public static bool left;
       public static bool center;
        public static bool right;
        int asteroidCount = 0;
        

        public Form1()
        {
            InitializeComponent();
            left = right = false;
            center = true;
            pictureBox1.Image = Properties.Resources.airplaneImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Properties.Resources.airplaneImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Image = Properties.Resources.airplaneImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Visible = pictureBox3.Visible = false;
            pictureBox4.SendToBack();
            scene = new Scene();
            timer1.Start();
            timer2.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (left == true)
                     return;
                else
                {
                    if (center == true)
                    {
                        left = true;
                        center = false;
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                    }
                    if (right == true)
                    {
                        center = true;
                        right = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                    }
                }
            }
            if(e.KeyCode == Keys.Right)
            {
                if (right == true)
                    return;
                else
                {
                    if(center == true)
                    {
                        right = true;
                        center = false;
                        pictureBox3.Visible = true;
                        pictureBox2.Visible = false;
                    }
                    if(left == true)
                    {
                        center = true;
                        left = false;
                        pictureBox2.Visible = true;
                        pictureBox1.Visible = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.generate();
            addAsteroid(scene.asteroidi.Last().X);
            scene.move();
            scene.checkHit();
            //if (scene.asteroidi.Count > 0 && scene.asteroidi.ElementAt(0).Y > 300) { 
            //    scene.remove();
            //    asteroidCount--;
            //}
            //if (asteroidCount == 0)
            //{
            //    scene.generate();
            //    asteroidCount++;
            //    addAsteroid(scene.asteroidi.Last().X);
            //}
            //else if (asteroidCount != scene.asteroidi.Count)
            //{
            //    scene.generate();
            //    asteroidCount = scene.asteroidi.Count;
            //    addAsteroid(scene.asteroidi.Last().X);
            //}


        }

        private void addAsteroid(int X)
        {
            PictureBox pb = new PictureBox
            {
                Name = "asteroid" + asteroidCount,
                Location = new Point(X, 30),
                Visible = true
            };

            Controls.Add(pb);
            pb.Image = Properties.Resources.asteroid;
            pb.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach(PictureBox pb in Controls.OfType<PictureBox>())
            {
                if(pb.Name.Contains("asteroid"))
                {
                    pb.Location = new Point(pb.Location.X, pb.Location.Y + 30);
                }
            }
        }
        public static void stop()
        {
            Application.Exit(); 
        }
        
    }
}

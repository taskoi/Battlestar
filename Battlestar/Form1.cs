using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Battlestar
{

    public partial class Form1 : Form
    {
        Scene scene;
        public bool left;
        public bool center;
        public bool right;
        int asteroidCount = 0;
        bool tStop = false;

        public Form1()
        {
            InitializeComponent();

            scene = new Scene();

            left = right = false;
            center = true;
            pictureBox1.Image = Properties.Resources.airplaneImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.airplaneImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.airplaneImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox1.Visible = pictureBox3.Visible = false;

            

            timer1.Start();
            timer2.Start();

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (tStop)
                {
                    timer1.Start();
                    timer2.Start();
                    tStop = false;
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    tStop = true;
                }
            }
            if (e.KeyCode == Keys.Left)
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
            if (e.KeyCode == Keys.Right)
            {
                if (right == true)
                    return;
                else
                {
                    if (center == true)
                    {
                        right = true;
                        center = false;
                        pictureBox3.Visible = true;
                        pictureBox2.Visible = false;
                    }
                    if (left == true)
                    {
                        center = true;
                        left = false;
                        pictureBox2.Visible = true;
                        pictureBox1.Visible = false;
                    }
                }
            }
        }


        private void addAsteroid(int X)
        {
            PictureBox pb = new PictureBox
            {
                Name = "asteroid" + asteroidCount,
                Location = new Point(X, 5),
                Visible = true
            };

            Controls.Add(pb);
            pb.Image = Properties.Resources.asteroid;
            pb.BackColor = Color.Transparent;
            pb.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.generate();
            addAsteroid(scene.asteroidi.Last().X);
            scene.move();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            bool hasCollision = false;

            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                if (pb.Name.Contains("asteroid"))
                {
                    if (pb.Tag != null)
                    {
                        continue;
                    }

                    Size s = pb.Size;
                    pb.Location = new Point(pb.Location.X, pb.Location.Y + 30);
                    Point pos = pb.Location;
                    Point planeLeftPos = pictureBox1.Location;
                    Point planeCenterPos = pictureBox2.Location;
                    Point planeRightPos = pictureBox3.Location;
                    Size planeSize = pictureBox1.Size;

                    bool hitVertical = (pos.Y + s.Height) >= (planeLeftPos.Y);
                    bool hitLeftHorizontal = (pos.X >= planeLeftPos.X) && pos.X <= (planeLeftPos.X + planeSize.Width);
                    bool hitCenterHorizontal = (pos.X >= planeCenterPos.X) && pos.X <= (planeCenterPos.X + planeSize.Width);
                    bool hitRightHorizontal = (pos.X >= planeRightPos.X) && pos.X <= (planeRightPos.X + planeSize.Width);

                    hasCollision = hitVertical && ((left && hitLeftHorizontal) || (center && hitCenterHorizontal) ||
                                                   (right && hitRightHorizontal));

                    if (pos.Y > this.Height)
                    {
                        pb.Tag = true;
                    }
                }
            }

            if (hasCollision)
            {
                this.Close();

            }

        }
    }

}

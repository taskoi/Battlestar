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
    public partial class Replay : Form
    {
        public Replay()
        {
            InitializeComponent();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Show();
            Form1 game = new Form1();
            if(game.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

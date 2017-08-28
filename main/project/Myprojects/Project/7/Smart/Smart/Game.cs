using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart
{
    public partial class Game : Form
    {

        public int speed_left = 4; // speed of the ball
        public int speed_top = 4;
        public int point = 0; // scored points
        public Game()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide(); // hide the cursor

            this.FormBorderStyle = FormBorderStyle.None; // Remove any border
            this.TopMost = true;                         // bring the form  to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; // make it fullscreen

            racket.Top = playground.Bottom - (playground.Bottom / 10); // set position of racket




        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left; // move the ball
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right) // racket collision
            {
                speed_top += 2;
                ball.Left += 2;
                speed_top = -speed_top; // change direction
                point += 1;
            }
            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right <= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom <= playground.Bottom)
            {
                timer1.Enabled = false; //game stop
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); 
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}

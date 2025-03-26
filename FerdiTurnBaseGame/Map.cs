using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FerdiTurnBaseGame
{
    public partial class Map : Form
    {
        public int choosenplayer { get; set; }
        List<string> playerMov = new List<string>();
        int steps;
        int SlowdownFps = 0;
        bool goLeft, goRight, goUp, goDown;
        int speed = 20;
        String LastPosition = "Right";
        public Map()
        {
            InitializeComponent();
            Setup();
            BackgroundFx();
        }



        private void Collision()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
        private void BackgroundFx()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"assets\Naruto - Main theme (Flute cover).wav");
            simpleSound.PlayLooping();
        }

        private void Map_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    pictureBox1.Left -= speed;
                    goLeft = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    pictureBox1.Left += speed;
                    goRight = true;
                    break;
                case Keys.Up:
                case Keys.W:
                    pictureBox1.Top -= speed;
                    goUp = true;
                    break;
                case Keys.Down:
                case Keys.S:
                    pictureBox1.Top += speed;
                    goDown = true;
                    break;
            }
            Collision();
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
                pictureBox1.Image = Image.FromFile(playerMov[7]);
                LastPosition = "Left";
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
                pictureBox1.Image = Image.FromFile(playerMov[0]);
                LastPosition = "Right";
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
                if (LastPosition == "Right")
                {
                    pictureBox1.Image = Image.FromFile(playerMov[0]);
                }
                else if (LastPosition == "Left")
                {
                    pictureBox1.Image = Image.FromFile(playerMov[7]);
                }


            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;

                if (LastPosition == "Right")
                {
                    pictureBox1.Image = Image.FromFile(playerMov[0]);
                }
                else if (LastPosition == "Left")
                {
                    pictureBox1.Image = Image.FromFile(playerMov[7]);
                }
            }

        }


        private void TimeEvent(object sender, EventArgs e)
        {
            if (goUp == true && LastPosition == "Left")
            {
                AnimatedPlayer(8, 13);
            }
            if (goUp == true && LastPosition == "Right")
            {
                AnimatedPlayer(1, 6);
            }
            if (goDown == true && LastPosition == "Left")
            {
                AnimatedPlayer(8, 13);
            }
            if (goDown == true && LastPosition == "Right")
            {
                AnimatedPlayer(1, 6);
            }
            if (goRight == true)
            {
                AnimatedPlayer(1, 6);
            }
            if (goLeft == true)
            {
                AnimatedPlayer(8, 13);
            }

            this.Invalidate();


        }
        private void Setup()
        {
            int Selected;
            Selected = SelectPoly.selected.GetPlayer()[0].choosedplayer;

            if (Selected == 1)
            {
                playerMov = Directory.GetFiles("assets\\Sasuke_Movement\\", "*.png").ToList();
                pictureBox1.Image = Image.FromFile(playerMov[0]);
                pictureBox2.Image = Image.FromFile("assets\\Naruto_Movement\\Naruto_Mov_07.png");
            }
            else if (Selected == 0)
            {
                playerMov = Directory.GetFiles("assets\\Naruto_Movement\\", "*.png").ToList();
                pictureBox1.Image = Image.FromFile(playerMov[0]);
                pictureBox2.Image = Image.FromFile("assets\\Sasuke_Movement\\Sasuke_Mov_07.png");
            }
            this.BackgroundImage = Image.FromFile("assets\\Map.jfif");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            //BackgroundFx();
            timer1.Enabled = true;
        }

        private void AnimatedPlayer(int start, int end)
        {
            SlowdownFps += 1;
            if (SlowdownFps == 5)
            {
                steps++;
                SlowdownFps = 0;
            }

            if (steps > end || steps < start)
            {
                steps = start;
            }

            pictureBox1.Image = Image.FromFile(playerMov[steps]);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private bool Righw = false;
        private bool leftw = true;
        private bool top = false;

        //private
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxPlayer.Location = new Point(Player.X, Player.Y);
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

           

            if (e.KeyData == Keys.D)
            {
                Player.MoveRight(pictureBoxPlayer, 50);
                
            }
            if (e.KeyData == Keys.A)
            {
                Player.MoveLeft(pictureBoxPlayer, 50);
               

            }
           
        }





        private void ControlTopAndDown()
        {

            if (top == false)
            {

                if (!pictureBoxEnemy.Bounds.IntersectsWith(DownWall.Bounds))
                {

                    Enemy.MoveDown(pictureBoxEnemy, 10);

                }
                else
                {
                    top = true;


                     //
                }
            }
            else if (top == true)
            {

                if (!pictureBoxEnemy.Bounds.IntersectsWith(TopWall.Bounds))
                {
                    Enemy.MoveUP(pictureBoxEnemy, 10);
                }
                else
                {


                    top = false;
                }


            }
        }
          private void ControlLeftRight()
        {

            if (Righw == false)
            {

                if (!pictureBoxEnemy.Bounds.IntersectsWith(RightWall.Bounds))
                {
                    Enemy.MoveRight(pictureBoxEnemy, 30);
                   

                }
                else
                {
                    Righw = true;
                    leftw = false;


                }
            }
            else if (leftw == false)
            {
               
                if (!pictureBoxEnemy.Bounds.IntersectsWith(LeftWall.Bounds))
                {
                    Enemy.MoveLeft(pictureBoxEnemy, 30);
                }
                else
                {

                    leftw = true;
                    Righw = false;
                }

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
         


            //if (pictureBoxPlayer.Bounds.Top < pictureBoxEnemy.Bounds.Bottom)
            //{


            //    Enemy.MoveUP(pictureBoxEnemy, 300);

            //    Player.Health -= 10;
            //    LabelHealth.Text = Player.Health.ToString() + "%";

            //}
            if (pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxEnemy.Bounds))
            {
                 Enemy.MoveUP(pictureBoxEnemy, 500);
             
            }
          

            else
            {
                ControlLeftRight();
                ControlTopAndDown();
            }

       







        }
    }
}

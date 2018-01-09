using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class Enemy
    {
        public static int Y = 40;
        public static int X = 500;
        public static int Health = 100; 

        public static void MoveRight(Control GameObject, int Speed)
        {
            X += Speed;
            GameObject.Location = new System.Drawing.Point(X, Y);
        }

        public static void MoveLeft(Control GameObject, int Speed)
        {
            X -= Speed;
            GameObject.Location = new System.Drawing.Point(X, Y);
        }
        public static void MoveUP(Control GameObject, int Speed)
        {
            Y -= Speed;
            GameObject.Location = new System.Drawing.Point(X, Y);
        }
        public static void MoveDown(Control GameObject, int Speed)
        {
            Y += Speed;
            GameObject.Location = new System.Drawing.Point(X, Y);
        }
    }
}

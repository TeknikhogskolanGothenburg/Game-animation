using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SpaceInvaders
{
   public class Player
    {

        public static int Y = 776;
        public static int X = 783;
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







    }
}

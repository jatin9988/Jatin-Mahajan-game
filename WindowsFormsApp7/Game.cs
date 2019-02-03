using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
   public class Game
    {
        int ran;
        public int rdm()
        {
            //below code for spining the chamber and it will pick bullet randomly
            Random rnd = new Random();
            //below code helps to pick random number between 1-7.
            return ran = rnd.Next(1, 7);

        }

        public int spin(int Sf)
        {
            if (Sf == 6)
            {
                Sf = 1;
            }
            else
            {
                Sf++;
            }
            return Sf;

        }

    }
}

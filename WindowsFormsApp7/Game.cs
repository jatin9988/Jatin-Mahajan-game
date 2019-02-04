using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
   public class Game
    {
        public int load;
        public int Spin;
        public int shoot;

        public int replay = 2;
        int ran;
        public int rdm()
        {
            //below code for spining the chamber and it will pick bullet randomly
            Random rnd = new Random();
            //below code helps to pick random number between 1-7.
            return ran = rnd.Next(1, 7);

        }

        public int spin(int Spinf)
        {
            if (Spinf == 6)//it cehcks if spinf is equal to 6
            {
                Spinf = 1;//it sets the value of spinf to 1
            }
            else
            {
                Spinf++;//it increase the value of spinf by 1
            }
            return Spinf;//it retuns the value of spinf

        }

    }
}

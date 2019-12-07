using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaurSimran_ShootGame
{
    public class area{
        public void trigger() { }
        public void empty() { }



    }
    public class gameTask : area
    {
        int cl = 0;
        Random instance = new Random();
        public void trigger() {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(kaurSimran_ShootGame.Properties.Resources.mg);
            obj.Play();
        }
        public int fire() {
            return instance.Next(2, 6);
        }
        public int firesound(int r,int cl) {

            trigger();

            if (cl == r)
            {
                  
                return 0;
            }
            else {
                return 1;
            }
        }
    }
}

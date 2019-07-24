using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
namespace FavourTomGame
{//Folllowed Tutorial on youtube
    //https://www.youtube.com/watch?v=ZcQxUlMz7-w
    class Sound
    {
        //Audio Class, to load file sound.wav at end of game
        private SoundPlayer Player;
        public
        Sound()//constructor, public so can make instence in "MarioGame"
        {
            Player = new SoundPlayer();
            Player.Stream = Properties.Resources.sound_wav;
        }
        ~Sound()
        {

        }
        //Play using Play Fucnction
        public void PlaySound()
        {
            Player.Play();

        }
    }
}

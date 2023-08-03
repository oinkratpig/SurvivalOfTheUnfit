using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    public static class Sounds
    {
        public static Stream Select = Properties.Resources.sndSelect;

    } // end class Sounds

    public static class Sound
    {
        public static void Play(Stream soundName)
        {
            soundName.Position = 0;
            using (SoundPlayer player = new SoundPlayer(soundName))
                player.Play();

        } // end Play

    } // end class Sound

} // end namespace

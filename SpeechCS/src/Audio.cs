using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Audio
    {
        public static void PlayAudio(Sound audio)
        {
            PlaySound(audio);
            Parser.soundPlayed = true;
        }

        public static void LoadAudio()
        {
            Program.effect = LoadSound("resources/sounds/test.wav");
            Parser.soundLoaded = true;
        }
    }
}

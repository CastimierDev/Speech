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

        public static void LoadAudio(int i, string[] objec)
        {
            try
            {
                Program.effect = LoadSound("resources/sounds/" + objec[i] + ".wav");
                Parser.soundLoaded = true;
                Console.WriteLine("Loaded Audio: " + objec[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed To Load Audio!");
            }
        }
    }
}

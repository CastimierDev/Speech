using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.KeyboardKey;

namespace Speech
{
    public class Input
    {
        public static void CheckInput(int i)
        {
            if (IsKeyPressed(KEY_SPACE) && i <= Line.linesAmount) IncreaceIndex();
        }

        public static void IncreaceIndex()
        {
            Program.index += 1;
            Parser.textureLoaded = false;
            Parser.soundLoaded = false;
        }
    }
}
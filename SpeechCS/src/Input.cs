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
        public static int MakeChoice(string[] choices)
        {
            int input = 0;

            if (IsKeyPressed(KEY_ONE)) input = 1;
            if (IsKeyPressed(KEY_TWO)) input = 2;
            if (IsKeyPressed(KEY_THREE)) input = 3;
            if (IsKeyPressed(KEY_FOUR)) input = 4;
            if (IsKeyPressed(KEY_FIVE)) input = 5;
            if (IsKeyPressed(KEY_SIX)) input = 6;
            if (IsKeyPressed(KEY_SEVEN)) input = 7;
            if (IsKeyPressed(KEY_EIGHT)) input = 8;
            if (IsKeyPressed(KEY_NINE)) input = 9;

            int output = input - 1;

            if (input != 0) Console.WriteLine(choices[output]);

            return output;
        }

        public static void IncreaceIndex()
        {
            Program.index += 1;
            Parser.textureLoaded = false;
            Parser.soundLoaded = false;
            Choice.choicesInitialized = false;
        }
    }
}
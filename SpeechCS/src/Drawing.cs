using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Drawing
    {
        public static int bgX = 0;
        public static int bgY = 0;
        public static Color bgColor;

        public static void DrawSay(int i, string[] objec, int x, int y, Color color)
        {
            DrawText(objec[i], x, y, Settings.fontSize, color);
        }
        public static void DrawPic(int i, string[] objec, int x, int y, Color color)
        {
            DrawTexture(Program.texture, x, y, color);
        }
        public static void DrawBg(int i)
        {
            DrawTexture(Program.background, bgX, bgY, bgColor);
            Console.WriteLine("Background Drawn!");
        }

        public static void LoadPic(int i, string[] objec)
        {
            Program.texture = LoadTexture("resources/images/" + objec[i] + ".png");
            Parser.textureLoaded = true;
        }
        public static void LoadBackground(int i, string[] objec, int x, int y, Color color)
        {
            bgX = x;
            bgY = y;
            bgColor = color;
            Program.background = LoadTexture("resources/images/" + objec[i] + ".png");
            Parser.backgroundLoaded = true;
        }

        public static void DrawDevMode(int i)
        {
            int min = 0;
            if (GetFPS() < 1000) min = 30;
            if (GetFPS() >= 1000) min = 45;

            DrawFPS(Settings.screenWidth - min, 0);

            DrawText(i.ToString(), Settings.screenWidth - 120, 25, Settings.fontSize, GREEN);
        }
    }
}

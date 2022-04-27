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
            //Console.WriteLine("Background Drawn!");
        }
        public static void DrawChoices(string[] texts, int amount, int x, int y, Color color)
        {
            int yChange = y;
            int xChange = x + Settings.fontSize * 2;

            for (int i = 0; i < amount; i++)
            {
                int num = i + 1;
                DrawText(num.ToString(), x, yChange, Settings.fontSize, color);
                DrawText(texts[i], xChange, yChange, Settings.fontSize, color);
                yChange += Settings.fontSize;
            }
        }
        public static void DrawContinue(int x, int y, Color color)
        {
            DrawText("Press Space To Continue", x, y, Settings.fontSize, color);
        }

        public static void LoadPic(int i, string[] objec)
        {
            try
            {
                Program.texture = LoadTexture("resources/images/" + objec[i] + ".png");
                Parser.textureLoaded = true;
                Console.WriteLine("Loaded Image: " + objec[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed To Load Image!");
            }
        }
        public static void LoadBackground(int i, string[] objec, int x, int y, Color color)
        {
            try
            {
                bgX = x;
                bgY = y;
                bgColor = color;
                Program.background = LoadTexture("resources/images/" + objec[i] + ".png");
                Parser.backgroundLoaded = true;
                Console.WriteLine("Loaded Background: " + objec[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed To Load Background!");
            }
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

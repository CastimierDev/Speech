using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public static class Program
    {
        public static int index = 0;
        public static Texture2D texture;
        public static Texture2D background;
        public static Texture2D speaker;
        public static Sound effect;
        public static Line line = new Line();
        public static bool isRunning = true;

        public static void Main()
        {
            SetTargetFPS(Settings.fps);
            InitWindow(Settings.screenWidth, Settings.screenHeigth, Settings.appName);
            InitAudioDevice();

            line = Define.DefineLines();

            while (isRunning)
            {
                if (line.command[index] != "choice") Input.CheckInput(index);

                BeginDrawing();

                ClearBackground(Settings.bgColor);

                if (Parser.backgroundLoaded) Drawing.DrawBg(index);

                Parser.Parse(index, line);

                //Drawing.DrawDevMode(index);

                DrawText(index.ToString(), 0, 100, 20, GREEN);

                EndDrawing();
            }
        }

        public static void End()
        {
            isRunning = false;
            Unload();
            CloseWindow();
        }

        public static void Unload()
        {
            UnloadTexture(background);
            UnloadTexture(texture);
            UnloadSound(effect);
        }
    }
}
﻿using System.Numerics;
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
        public static Sound effect;
        public static Line line = new Line();

        public static void Main()
        {
            SetTargetFPS(Settings.fps);
            InitWindow(Settings.screenWidth, Settings.screenHeigth, "Speech");
            InitAudioDevice();

            line = Define.DefineLines();

            effect = LoadSound("resources/sounds/test.wav");

            while (!WindowShouldClose())
            {
                Input.CheckInput(index);

                BeginDrawing();

                ClearBackground(Settings.bgColor);

                Parser.Parse(index, line);
                
                //Drawing.DrawDevMode(index);

                EndDrawing();
            }

            End();
        }

        public static void End()
        {
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
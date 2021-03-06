using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public static class Settings
    {
        public static int screenWidth = 800;
        public static int screenHeigth = 600;
        public static int fps = 120;
        public static Color bgColor = BLACK;
        public static int fontSize = 20;
        public static bool continueCommands = true;
        public static String appName = "SPEECH";
    }
}

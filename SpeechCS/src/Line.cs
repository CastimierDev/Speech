using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Line
    {
        public static int linesAmount = 256;

        public String[] command = new String[linesAmount];
        public String[] objec = new String[linesAmount];
        public Color[] color = new Color[linesAmount];
        public int[] x = new int[linesAmount];
        public int[] y = new int[linesAmount];
    }
}
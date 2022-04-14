using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Define
    {
        public static Line DefineLines()
        {
            Line line = new Line();
            line = SetLine("bg", "BLACK", WHITE, 0, 0, 0, line);
            line = SetLine("aud", "Hello World", WHITE, 0, 0, 1, line);
            line = SetLine("pic", "WHITE", WHITE, 0, 0, 2, line);
            line = SetLine("say", "Bye World", WHITE, 0, 0, 3, line);
            line = SetLine("end", "END", WHITE, 0, 0, 4, line);

            return line;
        }

        public static Line SetLine(String cmd, String obj, Color col, int xpos, int ypos, int index, Line ln)
        {
            ln.command[index] = cmd;
            ln.objec[index] = obj;
            ln.color[index] = col;
            ln.x[index] = xpos;
            ln.y[index] = ypos;

            return ln;
        }
    }
}

using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Parser
    {
        public static bool textureLoaded = false;
        public static bool soundLoaded = false;
        public static bool backgroundLoaded = false;
        public static bool soundPlayed = false;

        public static void Parse(int i, Line line)
        {
            switch (line.command[i])
            {
                case "say":
                    Drawing.DrawSay(i, line.objec, line.x[i], line.y[i], line.color[i]);
                    break;

                case "pic":
                    if (!textureLoaded) Drawing.LoadPic(i, line.objec);
                    Drawing.DrawPic(i, line.objec, line.x[i], line.y[i], line.color[i]);
                    break;

                case "bg":
                    //Console.WriteLine("Background");
                    if (!backgroundLoaded) Drawing.LoadBackground(i, line.objec, line.x[i], line.y[i], line.color[i]);
                    Drawing.DrawBg(i);
                    break;

                case "end":
                    Program.End();
                    break;

                case "audio":
                    if (!soundLoaded) Audio.LoadAudio(i, line.objec);
                    if (!soundPlayed) Audio.PlayAudio(Program.effect);
                    break;

                case "choice":
                    Choice.Choose(line, i);
                    break;
            }
        }
    }
}

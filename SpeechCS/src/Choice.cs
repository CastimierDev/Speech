using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Choice
    {
        static List<string> choicesList = new List<string>();
        static int choicesAmount;
        public static bool choicesInitialized = false;
        static string[] choicesString;

        public static void Choose(Line line, int i)
        {
            switch(line.objec[i])
            {
                case "test":
                    if (!choicesInitialized)
                    {
                        choicesList.Add("Frodo");
                        choicesList.Add("Sam");
                        choicesList.Add("Merry");
                        choicesList.Add("Pippin");
                        choicesString = choicesList.ToArray();
                        choicesAmount = choicesString.Length;
                        choicesInitialized = true;
                    }

                    Drawing.DrawChoices(choicesString, choicesAmount, line.x[i], line.y[i], line.color[i]);
                    int chosen = Input.MakeChoice(choicesString);
                    switch(chosen)
                    {
                        case 0:
                            Goto(3);
                            break;
                        case 1:
                            Goto(0);
                            break;
                        case 2:
                            Goto(4);
                            break;
                        case 3:
                            Goto(6);
                            break;
                    }

                    if (chosen != -1)
                    {
                        choicesList.Clear();
                    }

                    break;
            }
        }

        public static void Goto(int dest)
        {
            Program.index = dest;
        }
    }
}

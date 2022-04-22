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
                    Boolean goodInput = false;
                    switch(chosen)
                    {
                        case 0:
                            Goto(3);
                            goodInput = true;
                            break;
                        case 1:
                            Goto(0);
                            goodInput = true;
                            break;
                        case 2:
                            Goto(4);
                            goodInput = true;
                            break;
                        case 3:
                            Goto(6);
                            goodInput = true;
                            break;
                    }

                    if (goodInput)
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

using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class If
    {
        static int conditionNumber = 0;
        static int gotoNumber = 0;

        public static void Condition(string cond)
        {
            switch(cond)
            {
                case "0":
                    conditionNumber = 1;
                    gotoNumber = 4;
                    if (Variables.num1 == conditionNumber)
                    {
                        Choice.Goto(gotoNumber);
                    }
                    break;
            }
        }
    }
}

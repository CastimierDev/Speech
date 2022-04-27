using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Speech
{
    public class Variables
    {
        public static int loadedNum = 0;

        public static int num1 = 1;

        public static void Load(string varName)
        {
            loadedNum = int.Parse(varName);
        }

        public static void Set(string objec)
        {
            switch(objec)
            {
                case "num1":
                    num1 = loadedNum;
                    break;
            }
        }
    }
}

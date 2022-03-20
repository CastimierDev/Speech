import static com.raylib.Raylib.*;

public class Line {
    public static int linesAmount = 256;

    public static String[] command = new String[linesAmount];
    public static String[] object = new String[linesAmount];
    public static Color[] color = new Color[linesAmount];
    public static int[] x = new int[linesAmount];
    public static int[] y = new int[linesAmount];

    public static void SetLine(String cmd, String obj, Color col, int xpos, int ypos, int index)
    {
        command[index] = cmd;
        object[index] = obj;
        color[index] = col;
        x[index] = xpos;
        y[index] = ypos;
    }
}

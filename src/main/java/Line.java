import static com.raylib.Raylib.*;

public class Line {
    public static String command;
    public static String object;
    public static Color color;
    public int x;
    public int y;

    public Line(String cmd, String obj, Color col, int xpos, int ypos)
    {
        command = cmd;
        object = obj;
        color = col;
        x = xpos;
        y = ypos;
    }
}

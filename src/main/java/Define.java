import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;
import static com.raylib.Jaylib.WHITE;

public class Define {
    public static Line lines;

    public static void DefineLines()
    {
        lines.SetLine("bg", "BLACK", WHITE, 0, 0, 0);
        lines.SetLine("snd", "Hello World", WHITE, 0, 0, 1);
        lines.SetLine("pic", "WHITE", WHITE, 0, 0, 2);
        lines.SetLine("say", "Bye World", WHITE, 0, 0, 3);
        lines.SetLine("end", "END", WHITE, 0, 0, 4);
    }
}

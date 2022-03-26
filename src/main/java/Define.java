import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;
import static com.raylib.Jaylib.WHITE;

public class Define {
    public static Line lines;

    public static void DefineLines()
    {
        lines.SetLine("speak", "Hello World", BLACK, 0, 0, 0);
        lines.SetLine("speak", "Bye World", BLACK, 0, 0, 1);
        lines.SetLine("picture", "BLACK", WHITE, 0, 0, 2);
        lines.SetLine("picture", "WHITE", WHITE, 0, 0, 3);
    }
}

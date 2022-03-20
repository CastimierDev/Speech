import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;

public class Define {
    public static Line lines;

    public static void DefineLines()
    {
        lines.SetLine("speak", "Hello World", BLACK, 0, 0, 0);
        lines.SetLine("speak", "Bye World", BLACK, 0, 0, 1);
    }
}

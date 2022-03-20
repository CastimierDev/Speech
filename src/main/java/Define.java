import static com.raylib.Jaylib.BLACK;
import static com.raylib.Raylib.*;

public class Define {
    public static int linesAmount = 256;
    public static Line[] lines = new Line[linesAmount];

    public static void DefineLines()
    {
        lines[0] = new Line("Speak", "Hello World", BLACK, 50, 100);
    }
}

import static com.raylib.Raylib.*;

public class Input {
    public static void CheckInput(int i)
    {
        if (IsKeyPressed(KEY_SPACE) && i <= Line.linesAmount) IncreaceIndex();
    }

    public static void IncreaceIndex()
    {
        Main.index += 1;
        Parser.textureLoaded = false;
        Parser.soundLoaded = false;
    }
}

import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;

public class Main {
    public static int index = 0;
    public static Texture texture;
    public static Sound effect;

    public static void main(String args[])
    {
        SetTargetFPS(Settings.fps);
        InitWindow(Settings.screenWidth, Settings.screenHeigth, "Speech");
        InitAudioDevice();

        Define.DefineLines();

        while (!WindowShouldClose())
        {
            Input.CheckInput(index);

            BeginDrawing();

            ClearBackground(Settings.bgColor);

            Parser.Parse(index);

            Drawing.DrawDevMode();

            EndDrawing();
        }

        CloseWindow();
    }
}
import static com.raylib.Jaylib.WHITE;
import static com.raylib.Raylib.*;

public class Main {

    public static void main(String args[]) {
        SetTargetFPS(Settings.fps);
        InitWindow(Settings.screenWidth, Settings.screenHeigth, "Speech");
        InitAudioDevice();

        while (!WindowShouldClose())
        {
            BeginDrawing();

            ClearBackground(Settings.bgColor);

            EndDrawing();
        }

        CloseWindow();
    }
}
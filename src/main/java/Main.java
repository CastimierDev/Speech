import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;

public class Main {

    public static void main(String args[]) {
        SetTargetFPS(Settings.fps);
        InitWindow(Settings.screenWidth, Settings.screenHeigth, "Speech");
        InitAudioDevice();

        Define.DefineLines();

        while (!WindowShouldClose())
        {
            BeginDrawing();

            ClearBackground(Settings.bgColor);

            DrawText(Define.lines[0].object, Define.lines[0].x,Define.lines[0].y,Settings.fontSize,BLACK);

            EndDrawing();
        }

        CloseWindow();
    }
}
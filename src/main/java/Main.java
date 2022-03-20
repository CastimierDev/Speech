import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.BLACK;

public class Main {
    public static int index = 0;

    public static void main(String args[]) {

        SetTargetFPS(Settings.fps);
        InitWindow(Settings.screenWidth, Settings.screenHeigth, "Speech");
        InitAudioDevice();

        Define.DefineLines();

        while (!WindowShouldClose())
        {
            if (IsKeyPressed(KEY_SPACE) && index <= Line.linesAmount) index += 1;

            BeginDrawing();

            ClearBackground(Settings.bgColor);

            switch(Define.lines.command[index])
            {
                case "speak":
                    Drawing.DrawSpeak(index);
            }

            EndDrawing();
        }

        CloseWindow();
    }
}
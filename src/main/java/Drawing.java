import static com.raylib.Raylib.*;
import static com.raylib.Jaylib.GREEN;

public class Drawing {
    public static int bgX = 0;
    public static int bgY = 0;
    public static Color bgColor;

    public static void DrawSay(int i)
    {
        DrawText(Define.lines.object[i], Define.lines.x[i], Define.lines.y[i],Settings.fontSize,Define.lines.color[i]);
    }
    public static void DrawPic(int i)
    {
        DrawTexture(Main.texture, Define.lines.x[i], Define.lines.y[i], Define.lines.color[i]);
    }
    public static void DrawBg(int i)
    {
        DrawTexture(Main.background, bgX, bgY, bgColor);
    }

    public static void LoadPic(int i)
    {
        Main.texture = LoadTexture("resources/images/" + Define.lines.object[i] + ".png");
        Parser.textureLoaded = true;
    }
    public static void LoadBackground(int i)
    {
        bgX = Define.lines.x[i];
        bgY = Define.lines.y[i];
        bgColor = Define.lines.color[i];
        Main.background = LoadTexture("resources/images/" + Define.lines.object[i] + ".png");
        Parser.backgroundLoaded = true;
    }

    public static void DrawDevMode(int i)
    {
        int min = 0;
        if (GetFPS() < 1000) min = 30;
        if (GetFPS() >= 1000) min = 45;

        DrawFPS(Settings.screenWidth - min,0);

        DrawText(Define.lines.object[i], Settings.screenWidth - 50, 25, 20, GREEN);
    }
}

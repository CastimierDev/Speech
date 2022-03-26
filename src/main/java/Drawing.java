import static com.raylib.Raylib.*;

public class Drawing {
    public static void DrawSpeak(int i)
    {
        DrawText(Define.lines.object[i], Define.lines.x[i], Define.lines.y[i],Settings.fontSize,Define.lines.color[i]);
    }
    public static void DrawImage(int i)
    {
        DrawTexture(Main.texture, Define.lines.x[i], Define.lines.y[i], Define.lines.color[i]);
    }

    public static void LoadImage(int i)
    {
        Main.texture = LoadTexture("resources/images/" + Define.lines.object[i] + ".png");
        Parser.textureLoaded = true;
    }

    public static void DrawDevMode()
    {
        int min = 0;
        if (GetFPS() < 1000) min = 30;
        if (GetFPS() >= 1000) min = 45;

        DrawFPS(Settings.screenWidth - min,0);
    }
}

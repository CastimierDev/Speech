import static com.raylib.Raylib.*;

public class Drawing {
    public static void DrawSpeak(int i)
    {
        DrawText(Define.lines.object[i], Define.lines.x[i], Define.lines.y[i],Settings.fontSize,Define.lines.color[i]);
    }
}

import static com.raylib.Raylib.*;

public class Parser {
    public static boolean textureLoaded = false;
    public static boolean soundLoaded = false;

    public static void Parse(int i)
    {
        switch(Define.lines.command[i])
        {
            case "speak":
                Drawing.DrawSpeak(i);
                break;

            case "picture":
                if (!textureLoaded) Drawing.LoadImage(i);
                Drawing.DrawImage(i);
                break;

            /*case "sound":
                if (!soundLoaded) Drawing.LoadSound(i);
                Drawing.PlaySound(i);
                break;*/
        }
    }
}

import static com.raylib.Raylib.*;

public class Parser {
    public static boolean textureLoaded = false;
    public static boolean soundLoaded = false;
    public static boolean backgroundLoaded = false;

    public static void Parse(int i)
    {
        switch(Define.lines.command[i])
        {
            case "say":
                Drawing.DrawSay(i);
                break;

            case "pic":
                if (!textureLoaded) Drawing.LoadPic(i);
                Drawing.DrawPic(i);
                break;

            case "bg":
                Drawing.LoadBackground(i);
                break;

            case "end":
                Main.End();
                break;

            /*case "sound":
                if (!soundLoaded) Drawing.LoadSound(i);
                Drawing.PlaySound(i);
                break;*/
        }
    }
}

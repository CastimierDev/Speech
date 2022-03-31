import java.security.cert.Extension;

import static com.raylib.Raylib.*;
import static com.raylib.Raylib.Sound;

public class Parser {
    public static boolean textureLoaded = false;
    public static boolean soundLoaded = false;
    public static boolean backgroundLoaded = false;
    public static boolean soundPlayed = false;

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

            case "snd":
                if (!soundLoaded) Audio.LoadAudio();
                if (!soundPlayed) Audio.PlayAudio(Main.effect);
                break;
        }
    }
}

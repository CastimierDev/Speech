import com.raylib.Raylib;

import static com.raylib.Raylib.*;

public class Audio {
    public static void PlayAudio(Sound audio)
    {
        PlaySound(audio);
        Parser.soundPlayed = true;
    }

    public static void LoadAudio()
    {
        Main.effect = LoadSound("resources/sounds/test.wav");
        Parser.soundLoaded = true;
    }
}

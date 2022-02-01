using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public MusicLevel musicLevelPlaying;
    public static MusicController Instance;
    public AudioSource backgroundSource;
    public AudioSource sfxPlayer;

    public AudioClip audioMenu;
    public AudioClip ingame;
    public AudioClip credits;

    public AudioClip salto;
    public AudioClip muerte;


    private void Awake()
    {
        Instance = this;
        ChangeMusic(MusicLevel.MAINMENU);
        DontDestroyOnLoad(this);
    }
    public static void ChangeMusic(MusicLevel level)
    {
        if (level == Instance.musicLevelPlaying) return;
        Instance.musicLevelPlaying = level;
        switch (level)
        {
            case MusicLevel.CREDITS:
                Instance.backgroundSource.clip = Instance.credits;
                Instance.backgroundSource.Play();

                return;
            case MusicLevel.INGAME:
                Instance.backgroundSource.clip = Instance.ingame;
                Instance.backgroundSource.Play();

                return;
            case MusicLevel.MAINMENU:
                Instance.backgroundSource.clip = Instance.audioMenu;
                Instance.backgroundSource.Play();

                return;
        }
    }

    public static void PlaySfx(AudioClip clip)
    {
        Instance.sfxPlayer.clip = clip;
        Instance.sfxPlayer.Play();


    }
    public static void PlaySalto()
    {
        Instance.sfxPlayer.clip = Instance.salto;
        Instance.sfxPlayer.Play();


    }
    public static void PlayMuerte()
    {
        Instance.sfxPlayer.clip = Instance.muerte;
        Instance.sfxPlayer.time = 0.45f;
        Instance.sfxPlayer.Play();


    }

}

public enum MusicLevel { 
    CREDITS,
    MAINMENU,
    INGAME
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button playbutton;
    public Button quitbutton;
    public Button instructionsbutton;
    public Button creditsbutton;
    void Start(){
        playbutton.onClick.AddListener(()=>SceneManager.LoadScene(1));
        quitbutton.onClick.AddListener(()=>Application.Quit());
        instructionsbutton.onClick.AddListener(()=>SceneManager.LoadScene(2));
        creditsbutton.onClick.AddListener(()=>SceneManager.LoadScene(3));
        MusicController.ChangeMusic(MusicLevel.MAINMENU);
    }
}

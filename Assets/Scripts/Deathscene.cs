using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Deathscene : MonoBehaviour
{
    public Button replaybutton;
    public Button backbutton;
    void Start(){
        replaybutton.onClick.AddListener(()=>SceneManager.LoadScene(1));
        backbutton.onClick.AddListener(()=>SceneManager.LoadScene(0));
    }
    
}

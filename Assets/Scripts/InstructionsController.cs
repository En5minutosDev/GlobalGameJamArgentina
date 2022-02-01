using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InstructionsController : MonoBehaviour
{
    /*public Button nextbutton;
    public Button backbutton;*/
    public Button exitbutton;
    void Start(){
       /* nextbutton.onClick.AddListener(()=>SceneManager.LoadScene(0));
        backbutton.onClick.AddListener(()=>SceneManager.LoadScene(0));*/
        exitbutton.onClick.AddListener(()=>SceneManager.LoadScene(0));
    }

}

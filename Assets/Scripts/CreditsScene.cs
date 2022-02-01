using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CreditsScene : MonoBehaviour
{
    public Button menubutton;
    public SpriteRenderer m_imagen;
    public 
    void Start(){

        menubutton.onClick.AddListener(()=>SceneManager.LoadScene(0));
        StartCoroutine(CambioTexto(3f));
    }
   /* void Update(){
        StartCoroutine(CambioTexto(10f)); //Va dentro de la función o el Update
    }*/
    
    private IEnumerator CambioTexto(float time) //Se declara como una funcion; Debes crear las variables public SpriteRenderer m_imagen
    {
        yield return new WaitForSeconds(time);
        m_imagen.enabled = !m_imagen.enabled;



    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuit : MonoBehaviour
{
    public float k_Time;
    public KeyCode k_KeyQuit;
    public PlayerHealth m_PlayerHealt;
    public MovimientoPlataforma m_MovementPlataform;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    private void Start()
    {
        MusicController.ChangeMusic(MusicLevel.INGAME);
    }
    public void QuitGame()
    {
        if(Input.GetKeyDown(k_KeyQuit))
        {
            Application.Quit();

        }
    }

    private void Update()
    {
        k_Time = k_Time +Time.deltaTime;
        if(m_PlayerHealt.currentHealth < 1)
        {

            StartCoroutine(CallAgainScene(3.5f));
        }

        if (k_Time > 28f)
        {
            m_MovementPlataform.k_scaleRotation = 2f;
        }

    }

    private IEnumerator CallAgainScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(4);

        m_PlayerHealt.currentHealth = 1;

    }

}

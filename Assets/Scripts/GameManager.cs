using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject go_player;
    public PlayerHealth player_hp;
    public AudioSource k_volume;
    static float k_scaleVolumen;
    public GameObject menuVolume;
    public GameObject plataform;
    public GameObject go_Camera;
    public GameObject go_UI;
   
    // Start is called before the first frame update


    private void Awake()
    {
        //k_volume = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();

    }

    void Start()
    {

        go_player = GameObject.FindGameObjectWithTag("Player");
        player_hp = go_player.GetComponent<PlayerHealth>();




    }

    // Update is called once per frame
    void Update()
    {





        if (player_hp.currentHealth < 1)
        {
            if (plataform != null)
            {
                plataform.SetActive(false);
            }
      
        }

        

    }

    
   

}

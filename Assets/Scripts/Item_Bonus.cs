using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Bonus : MonoBehaviour
{
    public GameObject m_Player;

    public bool b_Desactivacion = false;


    void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player");
     
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        DesactivacionGO(other);
    }
    public void DesactivacionGO(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && b_Desactivacion)
        {
            gameObject.SetActive(false);
            
        }

        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public GameObject m_player;
    public float k_cronometro;
    public bool b_CronometroActivo = false;


    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        k_cronometro = 0f;
    }

    private void Update()
    {
        k_cronometro = k_cronometro + Time.deltaTime;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        CronometroDeVuelta(other);
    }
    public void CronometroDeVuelta(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && b_CronometroActivo)
        {
            Debug.Log(k_cronometro);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitYou : MonoBehaviour
{

    public int k_damageValue = 1;
    private int k_damage;
    public bool b_Hit;
    private PlayerHealth playerHelth;
    public PuntajeDeElectrones m_PuntajeElectrones;
    public bool b_IPositron;
    public bool b_IElectron;
    public bool b_INeutron;


    private void Start()
    {
        k_damage = k_damageValue;


    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && b_Hit)
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(k_damage);

        }

        if (other.gameObject.tag == "Player" && b_IPositron)
        {
            m_PuntajeElectrones.k_positrones = +1;
            gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "Player" && b_IElectron)
        {
            m_PuntajeElectrones.k_electrones = +1;
            gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "Player" && b_INeutron)
        {
            m_PuntajeElectrones.k_neutrones = +1;
            gameObject.SetActive(false);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(":D");
        if (collision.gameObject.tag == "Player" && b_Hit)
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(k_damage);
            gameObject.SetActive(false);

        }

        if (collision.gameObject.tag == "Player" && b_IPositron)
        {
            m_PuntajeElectrones.k_positrones = +1;
            gameObject.SetActive(false);

        }
        if (collision.gameObject.tag == "Player" && b_IElectron)
        {
            m_PuntajeElectrones.k_electrones = +1;
            gameObject.SetActive(false);

        }
        if (collision.gameObject.tag == "Player" && b_INeutron)
        {
            m_PuntajeElectrones.k_neutrones = +1;
            gameObject.SetActive(false);

        }

    }
}

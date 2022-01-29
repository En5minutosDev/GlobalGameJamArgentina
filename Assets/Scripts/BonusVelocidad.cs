using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusVelocidad : Item_Bonus
{


    public bool b_BonusVelocidad = false;
    public float k_ValorBonusVelocidad = 50f;
    private Rigidbody rb_other;


    void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
     
    }
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        AplicacionVelocidad(other);

        DesactivacionGO(other);
    }

    private void AplicacionVelocidad(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && b_BonusVelocidad)
        {
            rb_other = other.gameObject.GetComponent<Rigidbody>();
            rb_other.AddForce(Vector3.right * k_ValorBonusVelocidad);

        }
    }


}

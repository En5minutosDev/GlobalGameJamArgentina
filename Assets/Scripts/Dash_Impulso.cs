using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Impulso : MonoBehaviour
{



    public bool b_DashActive;
    public KeyCode k_TeclaDash;
    public float k_PotenciaDash = 500f;


    private Rigidbody m_MiRb;
    void Start()
    {
        m_MiRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(k_TeclaDash) && b_DashActive)
        {
            m_MiRb.AddForce(Vector3.right * k_PotenciaDash);
        }
    }
    // Update is called once per frame



 
}

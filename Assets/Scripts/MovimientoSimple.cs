using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{

    public Rigidbody m_MiRb;
    public float k_VelocidadMovimiento = 30f;
    public float k_velocidadRotacion = 300f;


    //Movimiento horizontal restringido
    public float k_EscalarVelocidad = 30f;
    public float k_VelocidadReposicion = 15f;

    private Vector3 m_DesplazamientoHorizontal;


    // Start is called before the first frame update
    void Start()
    {
        m_MiRb = GetComponent<Rigidbody>();
        

       
    }

    private void FixedUpdate()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        if (Input.GetAxisRaw("Horizontal") > 0f && (m_MiRb.transform.position.x < 5.5f))
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, 5.5f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));

        }

        if (Input.GetAxisRaw("Horizontal") < 0f && (m_MiRb.transform.position.x > -1.5f))
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, -1.5f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));
        }

        if(m_MiRb.position.x > 0f && Input.GetAxisRaw("Horizontal") == 0f)
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, 0f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));
        }
 
    }
}

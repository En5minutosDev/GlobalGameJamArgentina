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


    public Salto_Player b_SpectralForma;
    public float k_VerticalAceleration = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        m_MiRb = GetComponent<Rigidbody>();
        b_SpectralForma = GetComponent<Salto_Player>();



    }

    private void FixedUpdate()
    {

        if (b_SpectralForma)
        {
            if (Input.GetAxisRaw("Vertical") > 0f && (m_MiRb.transform.position.y < 8.3f))
            {
                m_MiRb.MovePosition(new Vector3(m_MiRb.position.x, Mathf.Lerp(m_MiRb.position.y, 8.3f, Time.fixedDeltaTime * k_VerticalAceleration), m_MiRb.position.z));

            }

            if (Input.GetAxisRaw("Vertical") < 0f && (m_MiRb.transform.position.y > 3.6f))
            {
                m_MiRb.MovePosition(new Vector3(m_MiRb.position.x, Mathf.Lerp(m_MiRb.position.y, 3.6f, Time.fixedDeltaTime * k_VerticalAceleration), m_MiRb.position.z));
            }

        }
       
        if (Input.GetAxisRaw("Horizontal") > 0f && (m_MiRb.transform.position.x < 5.5f))
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, 5.5f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));

        }

        if (Input.GetAxisRaw("Horizontal") < 0f && (m_MiRb.transform.position.x > -1.5f))
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, -1.5f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));
        }

        if (m_MiRb.position.x > 0f && Input.GetAxisRaw("Horizontal") == 0f)
        {
            m_MiRb.MovePosition(new Vector3(Mathf.Lerp(m_MiRb.position.x, 0f, Time.fixedDeltaTime), m_MiRb.position.y, m_MiRb.position.z));
        }
        
    }
}

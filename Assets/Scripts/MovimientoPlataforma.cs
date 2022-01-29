using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour
{

    public int[] k_NivelesDeVelocidad = new int[5] { 0, 1, 2, 3, 4 }; //Pensado para aumentar la velocidad de rotacion de acuerdo al nivel
    public int k_NivelActivo;
    public Rigidbody m_MiRb;
    public int k_VelocidadAngular;
    
    Vector3 m_VelocidadAnguloEuler;

    //Aplicación

    public bool b_RotacionX;
    public bool b_RotacionY;
    public bool b_RotacionZ;

    // Start is called before the first frame update
    void Start()
    {
        m_MiRb = GetComponent<Rigidbody>();

        SeleccionDeEjeDeRotacion(b_RotacionX, b_RotacionY, b_RotacionZ);

    }

    private void SeleccionDeEjeDeRotacion(bool b_RotacionX, bool b_RotacionY, bool b_RotacionZ)
    {
        if (b_RotacionX)
        {
            m_VelocidadAnguloEuler = new Vector3(k_VelocidadAngular, 0f, 0f);

        }
        if (b_RotacionY)
        {
            m_VelocidadAnguloEuler = new Vector3(0f, k_VelocidadAngular, 0f);

        }
        if (b_RotacionZ)
        {
            m_VelocidadAnguloEuler = new Vector3(0f, 0f, k_VelocidadAngular);

        }
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_VelocidadAnguloEuler * Time.fixedDeltaTime);
        m_MiRb.MoveRotation(m_MiRb.rotation * deltaRotation);
    }


}

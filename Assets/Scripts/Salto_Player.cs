using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto_Player : MonoBehaviour
{
    public float k_FuerzaDeSalto = 350f;



    public KeyCode m_TeclaDeSalto; //Selecciona en el inspector la tecla para saltar
    public bool b_Saltar;
    public Rigidbody m_MiRb;
    
    public bool b_plataforma;
    public float k_RadioCheckBox;


    public Transform m_OrigenCheckBox;
    public LayerMask m_Capa;

    private bool b_GizmoEncendido;

    // Start is called before the first frame update
    void Start()
    {
        m_MiRb = GetComponent<Rigidbody>();
        b_GizmoEncendido = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        ColisionPlataforma();
        AccionSaltar(b_plataforma);
    }

    public void AccionSaltar(bool b_plataforma)
    {
        if (Input.GetButtonDown("Jump") && b_plataforma)
        {
            m_MiRb.AddForce(Vector3.up * k_FuerzaDeSalto);
        }
    }

    


    void ColisionPlataforma()
    {
        b_plataforma = Physics.CheckBox(m_OrigenCheckBox.position, new Vector3(0.5f, 0.55f, 0.5f), Quaternion.identity, m_Capa);
    }

    void OnDrawGizmos() //Dibujo de caja gizmos de collider de deteccion
    {
        Gizmos.color = Color.red;
        
        if (b_GizmoEncendido)
            
            Gizmos.DrawWireCube(m_OrigenCheckBox.position, transform.localScale);
    }
}

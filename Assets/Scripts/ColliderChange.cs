using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChange : MonoBehaviour
{
    public Collider m_BoxCollider;
    public bool b_OffBoxCollider;


    // Update is called once per frame
    void Update()
    {
        if(b_OffBoxCollider)
        {
            m_BoxCollider.enabled = !m_BoxCollider.enabled;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{

    public Transform m_SecondPointCamera;
    public PlayerHealth m_playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(m_playerHealth.currentHealth < 1)
        {
            transform.position = Vector3.Lerp(transform.position, m_SecondPointCamera.position, Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, m_SecondPointCamera.rotation, Time.deltaTime);
            
        }


        
    }
}

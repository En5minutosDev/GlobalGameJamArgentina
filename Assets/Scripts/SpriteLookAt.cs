using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLookAt : MonoBehaviour
{

    public Transform m_GO;
    public Transform m_Camera;

    private void Awake()
    {
        m_GO = gameObject.GetComponent<Transform>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_GO.LookAt(m_Camera);
    }
}

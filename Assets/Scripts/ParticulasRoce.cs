using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasRoce : MonoBehaviour
{
    
    public bool b_MoveParticle = false;
    public float k_TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        b_MoveParticle = false;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = new Vector3(-0.8f, -0.1f, 0.40f);
        k_TimeCount = +k_TimeCount + Time.deltaTime;
        
        
        if (!b_MoveParticle )
        {
            transform.localPosition = new Vector3(-0.8f, -0.1f, 0.45f);
            
        }

    }
}

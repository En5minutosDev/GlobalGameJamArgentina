using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpectralToParticle : Salto_Player
{

    public ColliderChange m_colliderChange;
    public int k_mountElectron;
    public GameObject m_SpectralGO;
    public GameObject m_ParticleGO;
    public MovimientoSimple b_Spectral;
    public MainMenuQuit m_MenuQuit;

    // Start is called before the first frame update
    void Start()
    {
        b_Spectral = GetComponent<MovimientoSimple>();
    }

    // Update is called once per frame
    void Update()
    {


        if (m_MenuQuit.k_Time > 28f)
        {
            b_SpectralForm = true;
            m_MiRb.useGravity = false;
            m_ParticleGO.SetActive(false);
            m_SpectralGO.SetActive(true);
            b_Spectral.b_SpectralForma.b_SpectralForm = true;

        }
        else
        {
            b_SpectralForm = false;
            m_MiRb.useGravity = true;
            m_ParticleGO.SetActive(true);
            m_SpectralGO.SetActive(false);
            b_Spectral.b_SpectralForma.b_SpectralForm = false;


        }



    }
}

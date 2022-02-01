using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntajeDeElectrones : MonoBehaviour
{
    public Text m_electrones;
    public Text m_neutrones;
    public Text m_positrones;
    public Text m_MessageLigth;

    public int k_electrones;
    public int k_neutrones;
    public int k_positrones;

    public Text b_WeAreElement;

    public MainMenuQuit m_MainQuit;
    // Start is called before the first frame update
    void Start()
    {
        m_MessageLigth.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        m_electrones.text = k_electrones.ToString();
        m_neutrones.text = k_neutrones.ToString();
        m_positrones.text = k_positrones.ToString();

        if(m_MainQuit.k_Time > 28f)
        {
            m_MessageLigth.text = "Light Velocity - Mode Spectral";
        }
     


        



        if (k_electrones == 5 && k_neutrones == 5 && k_positrones == 5)
        {
            b_WeAreElement.text = "We can be BORON";
        }
        if (k_electrones == 4 && k_neutrones == 4 && k_positrones == 4)
        {
            b_WeAreElement.text = "We can be BERYLLIUM";
        }

        if (k_electrones == 3 && k_neutrones == 3 && k_positrones == 3)
        {
            b_WeAreElement.text = "We can be LITHIUM";


        }
        if (k_electrones == 2 && k_neutrones == 2 && k_positrones == 2)
        {
            b_WeAreElement.text = "We can be HELIUM";
        }

        if (k_electrones == 1 && k_neutrones == 1 && k_positrones == 1)
        {
            b_WeAreElement.text = "We can be HYDROGEN";
        }
        if (k_electrones == 0 && k_neutrones == 0 && k_positrones == 0)
        {
            b_WeAreElement.text = ">.<";
        }


    }
}

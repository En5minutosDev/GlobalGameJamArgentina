using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 1;
    public int currentHealth;
    public bool b_iAlive;

    public float k_TimeDisable = 0.7f;
    public GameObject m_MyGO;
    public SpriteRenderer m_PlayerSprite;
    public ParticleSystem m_DieParticle;






    public GameObject goMusic;
    public AudioSource musicBacground;
    private float delayTime;
    
    // Start is called before the first frame update
    private void Awake()
    {
        //goMusic = GameObject.FindGameObjectWithTag("Music");
        //musicBacground = goMusic.GetComponent<AudioSource>();

    }
    void Start()
    {
        currentHealth = maxHealth;
        b_iAlive = true;
        m_DieParticle.Pause();
        

    }

    // Update is called once per frame
    void Update()
    {
  
        //**MusicDamage();
        delayTime += Time.deltaTime;

        if (currentHealth <= 0)
        {
            MusicController.PlayMuerte();
            m_PlayerSprite.color = new Vector4(244f, 0f, 255f, 0f);
            m_DieParticle.Play();
            StartCoroutine(DisableGO(k_TimeDisable, m_MyGO));
        }
    }

    private void MusicDamage()
    {
        if (delayTime < 0f)
        {

            musicBacground.pitch = Mathf.Lerp(1f, -1f, 15f * Time.deltaTime);
        }
        else musicBacground.pitch = 1f;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }


    private IEnumerator DisableGO(float time, GameObject m_GO)
    {
        yield return new WaitForSeconds(time);
        m_GO.SetActive(false);
    }
}

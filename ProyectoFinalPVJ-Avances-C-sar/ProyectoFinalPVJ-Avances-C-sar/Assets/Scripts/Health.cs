using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private Animator anim;
    [SerializeField] private float iframe = 0.5f;
    private CapsuleCollider col;
    private bool iFrameActivated = false;

    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject deathScreen;

    private void Awake()
    {
        anim = GetComponent<Animator>(); 
        col = GetComponent<CapsuleCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {       
        if (iFrameActivated == false)
        {
            currentHealth -= damage;

            if (iframe != 0)
            {
                StartCoroutine(IframeUpdater());
            }
        }  

        if (currentHealth <= 0)
            {
                this.gameObject.GetComponent<PlayerMovement>().DeathUpdater();
                this.gameObject.GetComponent<PlayerCombat>().DeathUpdater();
                this.gameObject.GetComponent<PlayerRotation>().DeathUpdater();
                anim.SetBool("IsDead", true);
                StartCoroutine(DeathWaits());
            }

    }

    private IEnumerator IframeUpdater()
    {
        iFrameActivated = true;
        yield return new WaitForSecondsRealtime(iframe);
        iFrameActivated = false;
    }

    private IEnumerator DeathWaits()
    {
        yield return new WaitForSecondsRealtime(4.5f);
        playerUI.SetActive(false);
        yield return new WaitForSecondsRealtime(0.2f);
        deathScreen.SetActive(true);
    }
}

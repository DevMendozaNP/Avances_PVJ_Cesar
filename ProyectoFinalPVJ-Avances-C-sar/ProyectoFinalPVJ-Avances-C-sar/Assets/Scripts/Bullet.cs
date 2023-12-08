using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float TTL = 3;
    private GameObject bullet;
    [SerializeField] private int BulletDamage = 35;

    private void Awake()
    {
        bullet = this.gameObject;
    }

   
    private void Update()
    {
        if (TTL <= 0) 
        {
           Destroy(bullet);
        }
        TTL = TTL - Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var healthComponent = collision.gameObject.GetComponent<Health>();
            if (healthComponent != null) 
            {
                healthComponent.TakeDamage(BulletDamage);
            }
        }
        
        Destroy (bullet);
    }
}

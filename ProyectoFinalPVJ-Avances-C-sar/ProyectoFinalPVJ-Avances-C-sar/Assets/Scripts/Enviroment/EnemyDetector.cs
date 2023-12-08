using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [SerializeField] private GameObject levelBarrier1;
    [SerializeField] private GameObject levelBarrier2;
    [SerializeField] private GameObject levelBarrier3;
    [SerializeField] private GameObject victoria;
    private float enemiesToKill = 0f;
    private float deathQuota = 0f;

    public MeshCollider coll;
    private GameObject self;
    
    private void Awake()
    {
        coll = GetComponent<MeshCollider>();
        self = this.gameObject;
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            enemiesToKill += 1;
            deathQuota = enemiesToKill;
        }
    }

    public void DeathCounter(float death)
    {
        deathQuota -= death;

        if (deathQuota <= 0)
        {
            if(levelBarrier1 != null)
            {
                levelBarrier1.SetActive(false);
            }

            if(levelBarrier2 != null)
            {
                levelBarrier2.SetActive(false);
            }

            if(levelBarrier3 != null)
            {
                levelBarrier3.SetActive(false);
            }

            if(victoria != null)
            {
                victoria.SetActive(true);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PortalFunction : MonoBehaviour
{
    [SerializeField] Transform destination;
    [SerializeField] AudioSource teleSound;
    [SerializeField] GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && other.TryGetComponent<PlayerMovement>(out var mainPlayer))
        {
            mainPlayer.Teleport(destination.position);
            teleSound.Play();

            if(this.gameObject.CompareTag("Health"))
            {
                Player.GetComponent<Health>().GetHealth();
            }
        }
    }
}

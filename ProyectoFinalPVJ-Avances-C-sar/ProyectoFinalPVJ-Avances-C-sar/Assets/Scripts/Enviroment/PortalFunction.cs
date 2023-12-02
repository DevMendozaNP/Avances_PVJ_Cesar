using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFunction : MonoBehaviour
{
    [SerializeField] Transform destination;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && other.TryGetComponent<NewPlayerMovement>(out var mainPlayer))
        {
            mainPlayer.Teleport(destination.position);
        }
    }
}

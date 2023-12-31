using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    //private float rotationAngle;
    private Vector3 mousePos;
    private Vector3 mouseWorld;
    private Vector3 rotation = Vector3.zero;
    private bool PlayerDeath = false;

    [SerializeField] private Camera mainCamera;
    private void Awake()
    {
        
    }
    void Update()
    {
        if (PlayerDeath == false)
        {
            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLenght;
            if (groundPlane.Raycast(cameraRay, out rayLenght))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLenght);
                Debug.DrawLine(cameraRay.origin, pointToLook,Color.blue);
                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }
        }
    }

    public void DeathUpdater()
    {
        if (PlayerDeath == false)
        {
            PlayerDeath = true;
        }
    }

}

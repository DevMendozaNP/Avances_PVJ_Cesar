using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject Pause;
    private bool isPaused = false;

    private void OnPause(InputValue value)
    {
        if (isPaused == false)
        {
            Pause.SetActive(true);
            playerUI.SetActive(false);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            Pause.SetActive(false);
            playerUI.SetActive(true);
            isPaused = false;
            Time.timeScale = 1;
        }
    }
}

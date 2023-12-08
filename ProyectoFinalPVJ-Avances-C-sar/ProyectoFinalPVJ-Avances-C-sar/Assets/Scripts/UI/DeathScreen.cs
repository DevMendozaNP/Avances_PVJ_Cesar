using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public string scenename;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void RestartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    
    public void MenuOnClick()
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1;
    }
}

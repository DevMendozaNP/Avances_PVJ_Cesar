using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TitleScreenFuncionality : MonoBehaviour
{
    [SerializeField] private GameObject Tutorial;
    public string scenename;

    public void PlayOnClick()
    {
        SceneManager.LoadScene(scenename);
    }
    
    public void TeachOnClick()
    {
        Tutorial.SetActive(true);
    }

    public void LearnOnClick()
    {
        Tutorial.SetActive(false);
    }
}

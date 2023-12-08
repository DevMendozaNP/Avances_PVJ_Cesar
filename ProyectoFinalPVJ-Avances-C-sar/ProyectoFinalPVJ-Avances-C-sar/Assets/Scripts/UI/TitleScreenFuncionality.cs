using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class TitleScreenFuncionality : MonoBehaviour
{
    [SerializeField] private GameObject Tutorial;
    [SerializeField] private GameObject TitleInfo;
    [SerializeField] private AudioSource ButtonSound;

    public string scenename;

    public void PlayOnClick()
    {
        ButtonSound.Play();
        SceneManager.LoadScene(scenename);
    }
    
    public void TeachOnClick()
    {
        Tutorial.SetActive(true);
        TitleInfo.SetActive(false);
    }

    public void LearnOnClick()
    {
        TitleInfo.SetActive(true);
        Tutorial.SetActive(false);
    }
}

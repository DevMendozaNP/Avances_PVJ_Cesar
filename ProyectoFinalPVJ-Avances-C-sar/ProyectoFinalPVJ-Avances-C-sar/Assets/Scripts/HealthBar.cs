using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private AudioSource lvlMusic;
    private Health vida;
    private Slider slider;
    private void Awake()
    {
        vida = Player.GetComponent<Health>();
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        slider.value = vida.currentHealth;
    }

    public void StopTheFUCKINGMusic()
    {
        lvlMusic.Stop();
    }
}

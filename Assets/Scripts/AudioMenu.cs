using UnityEngine;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    public AudioManager audioManager;
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

        musicSlider.value = audioManager.musicVolume;
        sfxSlider.value = audioManager.sfxVolume;
    }

    public void SetMusicVolume(float volume)
    {
        audioManager.musicVolume = volume;
        audioManager.musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
        audioManager.sfxVolume = volume;
    }
}

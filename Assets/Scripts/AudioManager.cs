using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource musicSource, sfxSource;

    [Range(0.0f, 1.0f)] public float musicVolume = 1.0f;
    [Range(0.0f, 1.0f)] public float sfxVolume = 1.0f;

    public AudioClip collect, collect2, complete, death, hit, wrong, menuMusic, bgMusic;

    private void Start()
    {
        PlayMusic(menuMusic);
    }

    public void PlaySFX(AudioClip clip, float volume = 1.0f)
    {
        sfxSource.PlayOneShot(clip, volume * sfxVolume);
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.volume = musicVolume;
        musicSource.Play();
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = volume;
        musicSource.volume = musicVolume;
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = volume;
    }
}

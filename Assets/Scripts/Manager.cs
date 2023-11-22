using System.Collections;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    AudioManager audioManager;

    public TextMeshProUGUI health;
    public TextMeshProUGUI order;
    public TextMeshProUGUI score;

    public GameObject gameOver;
    public PlayerManager playerManager;

    private bool deathSoundPlayed = false;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        GameOver();
        order.SetText("Order: " + playerManager.holder);
        score.SetText("Score: " + playerManager.score);
    }

    public void GameOver()
    {
        health.SetText("HP: " + playerManager.hp);

        if (playerManager.hp <= 0 && !deathSoundPlayed)
        {
            audioManager.PlaySFX(audioManager.death);
            deathSoundPlayed = true; 
            gameOver.SetActive(true);
        }
    }
}

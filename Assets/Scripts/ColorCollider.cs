using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorCollider : MonoBehaviour
{
    AudioManager audioManager;

    public PlayerManager playerManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void Start()
    {
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioManager.PlaySFX(audioManager.collect2);
            Debug.Log("Collided with colors");
            Destroy(gameObject);
        }
    }
}
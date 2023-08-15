using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem explosion;
    public GameObject GameOverScreen;
    public GameObject obstacleGenerator;
    public GameObject trail;
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
        GameOverScreen.SetActive(true);
        obstacleGenerator.SetActive(false);
        trail.SetActive(false);
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        explosion.Stop();
    }

    private void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
    }
}



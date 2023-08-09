using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem explosion;
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
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



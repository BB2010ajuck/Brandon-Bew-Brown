using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int currentPlayerHealth = 15;
    public int enemyDamage = 2;
    private Animator playerAnimator;
    public PlayerExplosionParticles particles;
    public Text HealthText;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        particles = GetComponent<PlayerExplosionParticles>();
        HealthText.text = "/ " + currentPlayerHealth.ToString();
    }
    
    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");

        if (currentPlayerHealth <= 0)
        {
            particles.Explode();
            Invoke("ReloadScene", 5);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("CyberFu");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HitCollider")
        {
            HurtPlayer();
        }
    }
}
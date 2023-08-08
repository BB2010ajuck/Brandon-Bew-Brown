using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer()
    {
        Debug.Log("Damn Mother###### That Hurts");
        lives -= 1;
        hearts[lives].SetActive(false);
        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }

    
}

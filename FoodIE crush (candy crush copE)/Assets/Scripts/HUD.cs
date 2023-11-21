using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    public Level level;
    public TextMeshProUGUI remainingText;
    public TextMeshProUGUI remainingSubtext;
    public TextMeshProUGUI targetText;
    public TextMeshProUGUI targetSubtext;
    public TextMeshProUGUI scoreText;
    public Image[] stars;
    private int starIndex;
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        UpdateStars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateStars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (i == starIndex)
            {
                stars[i].enabled = true;
            }
            else
            {
                stars[i].enabled = false;
            }
        }
    }

    public void SetScore(int score)
    {
        scoreText.text = score.ToString();
        int visibleStar = 0;
        if (score >= level.score1Star && score < level.score2Star)
        {
            visibleStar = 1;
        }
        else if (score >= level.score2Star && score < level.score3Star)
        {
            visibleStar = 2;
        }
        else if (score >= level.score3Star)
        {
            visibleStar = 3;
        }
        starIndex = visibleStar;
        UpdateStars();
    }

    public void SetTarget(int target)
    {
        targetText.text = target.ToString();
    }

    public void SetRemaining(int remaining)
    {
        remainingText.text = remaining.ToString();
    }

    public void SetRemaining(string remaining)
    {
        remainingText.text = remaining;
    }
}

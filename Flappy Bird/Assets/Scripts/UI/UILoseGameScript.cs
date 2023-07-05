using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoseGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text playerScoreText;
    public Text bestScoreText;
    public Image medalImage;
    public void showUI()
    {
        gameObject.SetActive(true);
    }

    public void hideUI()
    {
        gameObject.SetActive(false);
    }

    public void SetPlayerScoreText(int score)
    {
        playerScoreText.text = score.ToString();
    }

    public void SetBestScoreTextt(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }

    public void  SetMedalImage(int score)
    {
        if(score >= 7)
        {

        } else if(score >= 4)
        {

        }
        else
        {

        }
    }
}


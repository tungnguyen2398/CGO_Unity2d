using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILoseGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text playerScoreText;
    public Text bestScoreText;
    public Image medalImage;
    public Sprite
        goldSprite,
        silverSprite,
        bronzeSprite;
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

    public void SetBestScoreText(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }

    public void  SetMedalImage(int score)
    {
        if(score >= 7)
        {
            medalImage.sprite = goldSprite;
        } else if(score >= 4)
        {
            medalImage.sprite = silverSprite;
        }
        else
        {
            medalImage.sprite = bronzeSprite;
            Debug.Log("bronze");
        }
    }

    public void PlayerAgainOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


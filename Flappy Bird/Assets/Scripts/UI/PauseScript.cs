using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public Sprite buttonPauseSprite;
    public Sprite buttonResumeSprite;
    public Image imageButton;
    public void PauseGameOnClick()
    {
        UIManager.Instance.PauseGame();
        if (GameManager.Instance.isPaused)
        {
            imageButton.sprite = buttonResumeSprite;
        }
        else
        {
            imageButton.sprite = buttonPauseSprite;
        }
    }
}

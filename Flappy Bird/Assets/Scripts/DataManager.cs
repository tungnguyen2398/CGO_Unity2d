using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int CurrentScore = 0;
    void Awake()
    {
        Instance = this;

        if (PlayerPrefs.HasKey("FirstPlay"))
        {
            CurrentScore = 0;
            PlayerPrefs.SetInt("BestScore", 0);
            PlayerPrefs.SetInt("FirstPlay", 0);
        }
    }

    void Update()
    {
        
    }

    public void SetCurrentScore(int score)
    {

    }
    public void SetBestScore()
    {
        int lastBestScore = PlayerPrefs.GetInt("BestScore");
        if(CurrentScore > lastBestScore)
        {
            PlayerPrefs.SetInt("BestScore", CurrentScore);
        }
    }

    public int GetScore()
    {
        return CurrentScore;
    }

    public void AddScore()
    {
        CurrentScore++;

        
    }
}

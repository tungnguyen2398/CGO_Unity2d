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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentScore(int score)
    {

    }
    public void SetBestScore(int score)
    {

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

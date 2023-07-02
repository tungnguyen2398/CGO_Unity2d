using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool GameOver;
    public bool GameStart;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        GameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameStart = true;
    }
    public void AddScore()
    {
        score++;
        UIManager.Instance.UpdateScore(score);
    }
}

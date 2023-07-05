using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool GameOver;
    public bool GameStart;
    public int score;
    public bool isPaused;
    private int collisionCount = 0;
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
    /*------Pause------- */
    public void StartGame()
    {
        GameStart = true;
    }

    /*------Score------- */ 
    public void AddScore()
    {
        score++;
        UIManager.Instance.UpdateScore(score);
    }

    /*------Pause------- */
    public void PauseGame()
    {
        if (isPaused == false)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    protected void Pause()
    {
        isPaused = true;
        Time.timeScale = 0;
    }

    protected void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (collisionCount == 0)
        {
            GameOver = true;
            AudioManager.Instance.PlayDeadSound();
            Debug.Log("bird is dead");
            UIManager.Instance.LoseGame();
        }
        collisionCount++;
    }

    public int GetScore()
    {
        return score;
    }
}

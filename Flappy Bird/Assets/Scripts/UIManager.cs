using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static UIManager Instance = null;
    public Text textScore;
    public GameObject buttonStartGame;
    public UILoseGameScript loseGamePanel;


    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void StartGameOnClick()
    {
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);

    }

    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }

    public void LoseGame()
    {
        loseGamePanel.showUI();
        GameManager.Instance.EndGame();
        Debug.Log("show UI");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerScripts bird;
    void Start()
    {
        bird = GetComponent<PlayerScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            CheckDie(collision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score check")
        {
            GameManager.Instance.AddScore();
            AudioManager.Instance.ScoreAudio();
        }
    }

    public void CheckDie(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ground"))
        {
            GameManager.Instance.EndGame();
        }
    }

}

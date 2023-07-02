using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public BoxCollider2D collision;
    [SerializeField] private int jumpForce;
    public float jumpAngle;
    public float rotateAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
        rb.gravityScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.GameOver) return;
        Jump();
        if(GameManager.Instance.GameStart == true)
        {
            rb.gravityScale = 1;
            RotateBird();
        }

    }


    public void Jump()
    {
        bool playerInput = Input.GetKeyDown(KeyCode.Space);
        if (playerInput)
        {
            rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
            transform.eulerAngles = new Vector3(0, 0, jumpAngle);
            AudioManager.Instance.PlayFlap();

        }
    }

    protected void RotateBird()
    {
        transform.eulerAngles -= new Vector3(0, 0, rotateAngle * Time.deltaTime);
    }
}

    

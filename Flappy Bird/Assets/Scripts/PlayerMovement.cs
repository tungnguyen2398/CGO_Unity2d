using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public BoxCollider2D collision;
    [SerializeField]private int jumpForce;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        bool playerInput = Input.GetKeyDown(KeyCode.Space);
        if (playerInput)
        {
            Debug.Log("Space pressed!");
            rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
        }
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "pipe down")
        {
            Debug.Log("collided with pipe");
        }

        if(collision.gameObject.name == "Ground")
        {
            Debug.Log("collided with ground");
        }
    }
}

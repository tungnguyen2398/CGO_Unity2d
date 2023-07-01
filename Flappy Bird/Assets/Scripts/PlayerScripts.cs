using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public BoxCollider2D collision;
    [SerializeField]private int jumpForce;
    public float jumpAngle;
    public float rotateAngle;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {     
        Jump();
        RotateBird();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "pipe down" || collision.gameObject
            .name == "pipe up")
        {
            Debug.Log("Bird is dead");
        }

        if(collision.gameObject.name == "Ground")
        {
            Debug.Log("Bird is dead");
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Score check")
        {
            Debug.Log("SCore!!");
        }
    }

    protected void Jump()
    {
        bool playerInput = Input.GetKeyDown(KeyCode.Space);
        if (playerInput)
        {
            rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
            transform.eulerAngles = new Vector3(0, 0, jumpAngle);
        }
    }

    protected void RotateBird()
    {
            transform.eulerAngles -= new Vector3(0, 0, rotateAngle * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.GameOver) return;
        destroyPipe();
        this.transform.position += Vector3.left * Time.deltaTime;
    }

   private void destroyPipe()
    {
        if(this.transform.position.x <= -5)
        {
            Destroy(gameObject);
        }
    }

}

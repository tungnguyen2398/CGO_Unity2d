using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public Transform spawnPosition;
    public float delayPerSpawn;
    public Vector2 offsetPipeSpawn;
    private float currentTimeSpawn;
    void Start()
    {
        
    }

    void Update()
    {
        if(currentTimeSpawn > delayPerSpawn)
        {
            currentTimeSpawn = 0;
            spawnPipe();
        }

        currentTimeSpawn += Time.deltaTime;
    }

    private void spawnPipe()
    {
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.position = spawnPosition.position;
        var offset = Random.Range(offsetPipeSpawn.x, offsetPipeSpawn.y);
        pipe.transform.position += new Vector3(0, offset);
    }
}

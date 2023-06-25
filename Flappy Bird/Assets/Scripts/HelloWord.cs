using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWord : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        Debug.Log("Awake is called");
    }

    private void OnEnable()
    {
        Debug.Log("Enable is called");
    }
    void Start()
    {
        Debug.Log("Start is called");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update is called");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable is called");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy is called");
    }
}

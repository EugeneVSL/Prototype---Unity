using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    // declare and initialize the bus speed
    private float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

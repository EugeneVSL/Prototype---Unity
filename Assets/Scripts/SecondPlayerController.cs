using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    private float speed = 15.0f;

    //declare and initialize the second player
    public GameObject player;

    private float horizontalInput;
    private float turnSpeed = 25.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get user's input for both axis
        horizontalInput = Input.GetAxis("HorizontalPlayerTwo");
        verticalInput = Input.GetAxis("VerticalPlayerTwo");

        // move the player two forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // turn he player left/right
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalInput);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // offset  for the main camera
    private Vector3 offsetMainCamera = new Vector3(-3.5f, 5, -12); 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offsetMainCamera;

        // // offset the frontcar camera
        // frontCarCamera.transform.position = player.transform.position + offsetFrontCarCamera;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject player;
    
    //declare cameras
    public GameObject mainCamera;
    public GameObject frontCarCamera;

    //offset for the frontcar camera
    private Vector3 offsetFrontCarCamera = new Vector3(0, 4.48f, -2.64f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // offset the frontcar camera
        frontCarCamera.transform.position = player.transform.position + offsetFrontCarCamera;

        if(Input.GetKeyDown(KeyCode.C)) {

            if(mainCamera.activeInHierarchy) {
                mainCamera.SetActive(false);
                frontCarCamera.SetActive(true);
            } else {
                mainCamera.SetActive(true);
                frontCarCamera.SetActive(false);
            }
        }
    }
}

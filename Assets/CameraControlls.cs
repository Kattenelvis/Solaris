using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlls : MonoBehaviour
{

    public Camera mainCamera;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float cameraXposition = mainCamera.transform.position.x;
        mainCamera.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0));
        mainCamera.transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")));
    }
}

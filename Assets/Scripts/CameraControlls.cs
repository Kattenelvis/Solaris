using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlls : MonoBehaviour
{

    public Camera mainCamera;
    public float panSenitivity;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float cameraXposition = mainCamera.transform.position.x + Input.GetAxis("Horizontal") * panSenitivity;
        float cameraYposition = mainCamera.transform.position.y;
        float cameraZposition = mainCamera.transform.position.z + Input.GetAxis("Vertical") * panSenitivity;

        mainCamera.transform.position = new Vector3(cameraXposition, cameraYposition, cameraZposition);

    }
}

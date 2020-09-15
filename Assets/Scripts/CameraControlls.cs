using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlls : MonoBehaviour
{
    public Camera mainCamera;
    public float panSenitivity;
    public float zoomSensitivity;
    public Vector3 lastClickedCoordinate;
    void Update()
    {
        Zoom();
        //Moves the ship to it's position. 
        if (lastClickedCoordinate != null && currentlySelectedGameObject != null && currentlySelectedGameObject.CompareTag("Selectable"))
        {
            currentlySelectedGameObject.transform.position = Vector3.MoveTowards(currentlySelectedGameObject.transform.position, lastClickedCoordinate, Time.deltaTime * this.gameObject.GetComponent<Main>().gameSpeed);
        }

        PanCamera();
        Selection();
    }

    void PanCamera()
    {
        float cameraXposition = mainCamera.transform.position.x + Input.GetAxis("Horizontal") * panSenitivity;
        float cameraYposition = mainCamera.transform.position.y;
        float cameraZposition = mainCamera.transform.position.z + Input.GetAxis("Vertical") * panSenitivity;

        mainCamera.transform.position = new Vector3(cameraXposition, cameraYposition, cameraZposition);
    }


    void Zoom()
    {
        mainCamera.transform.Translate(new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity));
    }
    private Transform selection;
    public GameObject currentlySelectedGameObject;

    public Texture2D highlightCursor;
    public Texture2D defaultCursor;
    //This function turns selected objects slightly green
    void Selection()
    {
        //Returns objects to normal once they're no longer selected
        if (selection != null)
        {
            selection = null;
            changeCursor(defaultCursor);
        }

        //Turns them green once they're selected
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;
            //Make sure this is not the backround plane that's used for co-ordinates  
            if (selection.gameObject.CompareTag("Selectable"))
            {
                changeCursor(highlightCursor, new Vector2(40, 40));
                currentlySelectedGameObject = selection.gameObject;
                if (Input.GetMouseButtonDown(1))
                {

                    print(lastClickedCoordinate);
                }
            }
            if (selection.gameObject.CompareTag("Astronomical_Object"))
            {
                changeCursor(highlightCursor, new Vector2(40, 40));

            }
            if (selection.gameObject.CompareTag("Plane"))
            {
                if (Input.GetMouseButtonDown(1))
                {
                    lastClickedCoordinate = hit.point;
                }
            }
        }
    }

    void changeCursor(Texture2D cursor)
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }
    void changeCursor(Texture2D cursor, Vector2 offset)
    {
        Cursor.SetCursor(cursor, offset, CursorMode.ForceSoftware);
    }



}
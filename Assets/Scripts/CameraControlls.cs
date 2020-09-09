using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlls : MonoBehaviour
{
    public Camera mainCamera;
    public float panSenitivity;
    public float zoomSensitivity;
    public Vector3 lastClickedCoordinate;

    public float GameSpeed;
    void Update()
    {
        Zoom();
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null && currentlySelectedGameObject.gameObject.CompareTag("Selectable"))
                {
                    lastClickedCoordinate = hit.point;
                }
            }
        }
        if (lastClickedCoordinate != null && currentlySelectedGameObject != null && currentlySelectedGameObject.CompareTag("Selectable"))
        {
            currentlySelectedGameObject.transform.position = Vector3.MoveTowards(currentlySelectedGameObject.transform.position, lastClickedCoordinate, Time.deltaTime * GameSpeed);
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

    public Material highlightMaterial;
    private Material defaultMaterial;
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
            var selectionRenderer = selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            selection = null;
        }

        //Turns them green once they're selected
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            //Make sure this is not the backround plane that's used for co-ordinates
            if (selectionRenderer != null && !selection.gameObject.CompareTag("Plane"))
            {
                Cursor.SetCursor(highlightCursor, Vector2.zero, CursorMode.ForceSoftware);
                defaultMaterial = selectionRenderer.material;
                selectionRenderer.material = highlightMaterial;
                currentlySelectedGameObject = selection.gameObject;
            }
        }
    }





}
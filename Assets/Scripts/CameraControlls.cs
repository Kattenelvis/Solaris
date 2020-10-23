using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CameraControlls : MonoBehaviour
{
    public Camera mainCamera;
    public float panSenitivity;
    public float zoomSensitivity;
    Vector3 lastClickedCoordinate;

    public void cameraControlls()
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
    GameObject currentlySelectedGameObject;

    [SerializeField] Texture2D highlightCursor;
    [SerializeField] Texture2D defaultCursor;
    [SerializeField] UIManager uiManager;
    public AstronomicalObject selectedAstronomicalObject;
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
                Select();
            }
            //If hovering mouse over a planet
            if (selection.gameObject.CompareTag("Astronomical_Object"))
            {
                SelectAstroObject();

            }
            if (selection.gameObject.CompareTag("Plane"))
            {
                SelectPlane(hit);
            }
        }   
    }


    void Select()
    {
        changeCursor(highlightCursor, new Vector2(40, 40));
        currentlySelectedGameObject = selection.gameObject;
        if (Input.GetMouseButtonDown(1))
        {
            print(lastClickedCoordinate);
        }
    }

    private void SelectAstroObject()
    {
        changeCursor(highlightCursor, new Vector2(40, 40));

        //If clicked on planet/asteroid/moon e.t.c
        if (Input.GetMouseButton(0))
        {
            //uiManager.showPlanet(selectedAstronomicalObject, false);
            selectedAstronomicalObject = selection.GetComponent<AstronomicalObject>();
            uiManager.showPlanet(selectedAstronomicalObject);
        }
    }
    private void SelectPlane(RaycastHit hit)
    {
        if (Input.GetMouseButtonDown(1))
            lastClickedCoordinate = hit.point;
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            selectedAstronomicalObject = null;
            uiManager.showPlanet(selectedAstronomicalObject);
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
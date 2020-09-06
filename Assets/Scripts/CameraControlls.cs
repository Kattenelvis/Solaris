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


    void Update()
    {
        float cameraXposition = mainCamera.transform.position.x + Input.GetAxis("Horizontal") * panSenitivity;
        float cameraYposition = mainCamera.transform.position.y;
        float cameraZposition = mainCamera.transform.position.z + Input.GetAxis("Vertical") * panSenitivity;

        mainCamera.transform.position = new Vector3(cameraXposition, cameraYposition, cameraZposition);


        Selection();


    }
    public Material highlightMaterial;
    public string selectableTag = "Selectable";
    [SerializeField] private Material defaultMaterial;
    private Transform _selection;
    void Selection()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                defaultMaterial = selectionRenderer.material;
                selectionRenderer.material = highlightMaterial;
            }
            _selection = selection;
        }
    }
}

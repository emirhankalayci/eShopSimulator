using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorOnMonitor;
    private FirstPersonController firstPersonController;
    public GameObject cross; 

    private void Awake()
    {
        firstPersonController = GetComponent<FirstPersonController>();
    }
    void Start()
    {
        //Cursor.visible = false;
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        firstPersonController.lockCursor = false;
        firstPersonController.crosshair = false;
        firstPersonController.enableZoom = false;
    }

    
    private void Update()
    {
        cross.gameObject.SetActive(false);
    }
    void OnMouseEnter()
    {    
        //Cursor.SetCursor(cursorOnMonitor, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}

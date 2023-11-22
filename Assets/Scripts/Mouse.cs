using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private Texture2D cursorArrow;
    private Vector2 cursorHotspot;
    void Start()
    {
        cursorHotspot = new Vector2(cursorArrow.width / 2, cursorArrow.height /2);
        Cursor.SetCursor(cursorArrow, cursorHotspot, CursorMode.Auto);
    }
    void Update()
    {
        
    }
}

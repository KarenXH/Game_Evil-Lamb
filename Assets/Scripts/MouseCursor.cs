using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public Texture2D mouseCursor;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(mouseCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

   
}

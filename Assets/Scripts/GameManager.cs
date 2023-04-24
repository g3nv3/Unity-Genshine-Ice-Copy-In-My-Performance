using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool cursorVisible = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            cursorVisible = !cursorVisible;
        Cursor.visible = cursorVisible;
    }
}

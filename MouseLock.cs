using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    public bool cursorVisible = false;
       
    void Update()
    {
        if(cursorVisible)
        {
            CursorVisible();
        }
        else
        {
            LockCursor();
        }    
    }

    public void UseCursor()
    {
        cursorVisible = !cursorVisible;
    }

    void CursorVisible()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
}

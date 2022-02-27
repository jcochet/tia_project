using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe pour déplacer un objet à l'aide de la souris
 * @author Julien Cochet
 */
public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    /* Script gérant le score */
    private TimerManager timerManager;

    public void Start()
    {
        timerManager = FindObjectOfType<TimerManager>();
    }

    public void OnMouseDown()
    {
        if (timerManager != null && !timerManager.GetGameOn())
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            // Store offset = gameobject world pos - mouse world pos
            mOffset = gameObject.transform.position - GetMouseWorldPos();
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        // pixel coordinates (x, y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void OnMouseDrag()
    {
        if (timerManager != null && !timerManager.GetGameOn())
        {
            transform.position = GetMouseWorldPos() + mOffset;
        }
    }
}

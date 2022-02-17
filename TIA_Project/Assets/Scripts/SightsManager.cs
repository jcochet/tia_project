using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Classe pour la gestion du viseur
 * @author Julien Cochet
 */
public class SightsManager : MonoBehaviour
{
    /* Image du viseur */
    public Image sights;

    /* Raycast pour checker si la cible est atteinte */
    private RaycastHit hit;

    public void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask) && hit.transform.gameObject.tag == "Target")
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            SetColor(Color.red);
        } else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            SetColor(Color.white);
        }
    }

    /**
     * Change la couleur du viseur
     * @param color Nouvelle couleur du viseur
     */
    private void SetColor(Color color)
    {
        sights.color = color;
    }
}

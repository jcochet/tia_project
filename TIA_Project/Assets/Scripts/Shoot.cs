using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe pour d�cocher des fl�ches
 * @author Julien Cochet
 */
public class Shoot : MonoBehaviour
{
    /* Prefab des fl�ches � trier */
    public GameObject arrow;
    /* Transform d'image traget */
    public Transform imageTarget;

    public void Update()
    {
        Fire();
    }

    /**
     * Tire une fl�che quand la touche "Fire1" est bass�e
     */
    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(arrow, this.transform);
            instance.transform.parent = imageTarget;
        }
    }
}

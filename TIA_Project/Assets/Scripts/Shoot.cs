using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe pour décocher des flèches
 * @author Julien Cochet
 */
public class Shoot : MonoBehaviour
{
    /* Prefab des flèches à trier */
    public GameObject arrow;
    /* Transform d'image traget */
    public Transform imageTarget;

    public void Update()
    {
        Fire();
    }

    /**
     * Tire une flèche quand la touche "Fire1" est bassée
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

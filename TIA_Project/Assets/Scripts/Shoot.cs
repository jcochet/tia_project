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

    /* Script gérant le score */
    private TimerManager timerManager;

    public void Start()
    {
        timerManager = FindObjectOfType<TimerManager>();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    /**
     * Tire une flèche si une partie est en cours
     */
    private void Fire()
    {
        if (timerManager != null && timerManager.GetGameOn())
        {
            GameObject instance = Instantiate(arrow, this.transform);
            instance.transform.parent = imageTarget;
        }
    }
}

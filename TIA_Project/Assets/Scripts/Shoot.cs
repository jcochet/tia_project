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

    /* Script g�rant le score */
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
     * Tire une fl�che si une partie est en cours
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

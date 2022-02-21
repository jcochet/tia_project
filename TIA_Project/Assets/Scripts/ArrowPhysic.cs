using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe pour la gestion de la physique des flèches
 * @author Julien Cochet
 */
public class ArrowPhysic : MonoBehaviour
{
    /* Force de l'objet */
    public float force = 50.0f;
    /* Temps, en secondes, avant la destruction de l'objet */
    public float lifeTime = 30.0f;
    /* Liste des objects cibles */
    public HashSet<string> targets = new HashSet<string> { "Target", "Ground" };

    /* Rigidbody */
    private Rigidbody rb;
    /* Script gérant le score */
    private ScoreManager scoreManager;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(force * transform.forward);
        Destroy(gameObject, lifeTime);
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(targets.Contains(collision.gameObject.tag))
        {
            rb.isKinematic = true;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            GetComponent<BoxCollider>().enabled = false;
            if(scoreManager != null && collision.gameObject.tag == "Target")
            {
                Debug.Log("Touché !");
                scoreManager.AddPoints(100);
            }
        }
    }

}

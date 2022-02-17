using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/**
 * Objet gérant le score du jeu
 * @author Julien Cochet
 */
public class ScoreManager : MonoBehaviour
{
    /* Score de la partie */
    private int score = 0;
    /* Texte affichant le score */
    private TextMeshProUGUI textMeshPro;

    public void Start()
    {
        textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
    }

    /**
     * Ajoute des points au score
     * @param points Points à ajouter
     */
    public void AddPoints(int points)
    {
        score += points;
        ShowScore();
    }

    /**
     * Affiche le score sur l'UI
     */
    private void ShowScore()
    {
        textMeshPro.text = "Score: " + score;
    }
}

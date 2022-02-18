using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/**
 * Script gérant le score du jeu
 * @author Julien Cochet
 */
public class ScoreManager : MonoBehaviour
{
    /* Texte affichant le score */
    public TextMeshProUGUI scoreText;
    /* Texte affichant le score final */
    public TextMeshProUGUI finalScoreText;

    /* Score de la partie */
    private int score = 0;

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
        scoreText.text = "Score: " + score;
        finalScoreText.text = "Final Score:\n" + score;
    }
}

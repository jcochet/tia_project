using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/**
 * Script gérant le timer du jeu
 * @author Julien Cochet
 */
public class TimerManager : MonoBehaviour
{
    /* Temps d'une partie */
    public float initialTime = 30.0f;
    /* Texte affichant le score */
    public TextMeshProUGUI textMeshPro;
    /* HUD du jeu */
    public GameObject gameHUD;
    /* Menu du jeu */
    public GameObject menu;

    /* Indique si une partie est en court */
    [SerializeField] private bool gameOn = true;

    /* Temps restant avant la fin de la partie */
    private float timeLeft = 0.0f;

    public void Start()
    {
        if (gameOn)
        {
            StartGame();
        } else
        {
            GameOver();
        }
    }

    public void Update()
    {
        if (gameOn)
        {
            timeLeft -= Time.deltaTime;
            ShowTime();
            if (timeLeft < 0)
            {
                GameOver();
            }
        }
    }

    /**
     * Démarre la partie
     */
    public void StartGame()
    {
        timeLeft = initialTime;
        menu.SetActive(false);
        gameHUD.SetActive(true);
        gameOn = true;
    }

    /**
     * Indique si une partie est en cours
     */
    public bool GetGameOn()
    {
        return gameOn;
    }

    /**
     * Met fin à la partie
     */
    private void GameOver()
    {
        gameOn = false;
        gameHUD.SetActive(false);
        menu.SetActive(true);
    }

    /**
     * Affiche le temps sur l'UI
     */
    private void ShowTime()
    {
        textMeshPro.text = "Time: " + timeLeft.ToString("F0");
    }
}

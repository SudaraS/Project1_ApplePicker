using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RoundScript : MonoBehaviour
{
    public TextMeshProUGUI roundText;  
    public Button restartButton;       
    private int currentRound = 1;     
    private int maxRounds = 4;         

    void Start()
    {
        UpdateRoundText();
        restartButton.gameObject.SetActive(false); 

        restartButton.onClick.AddListener(RestartGame);
    }

    public void UpdateRoundText()
    {
        if (currentRound <= maxRounds)
        {
            roundText.text = "Round " + currentRound;
        }
        else
        {
            GameOver();
        }
    }

    public void NextRound()
    {
        if (currentRound < maxRounds)
        {
            currentRound++;
            UpdateRoundText();
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        roundText.text = "Game Over";
        restartButton.gameObject.SetActive(true);  
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button startButton;

    void Start(){
        Time.timeScale = 0;
    }

    public void LoadGameScene(){
        startButton.interactable = false;

        startButton.gameObject.SetActive(false);

        Time.timeScale = 1;
        
        SceneManager.LoadScene("MainScene");
        
    }
}

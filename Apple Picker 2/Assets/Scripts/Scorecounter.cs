using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scorecounter : MonoBehaviour
{
    
    public int score = 0;

    private TMP_Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(uiText != null){
            uiText.text = score.ToString("#,0");
        }
        
    }
}

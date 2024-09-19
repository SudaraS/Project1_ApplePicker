using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public Scorecounter scoreCounter;
    void Start(){
        GameObject scoreGO = GameObject.Find("ScoreCounter");

        scoreCounter = scoreGO.GetComponent<Scorecounter>();
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.TryGetComponent<ICollectables>(out ICollectables collectables)){
            if(collectables.IsCollectable()){
                print("Apple collected");
                Destroy(collision.gameObject);
                scoreCounter.score += 100;

                if(scoreCounter.score % 3 == 0){
                    FindObjectOfType<RoundScript>().NextRound();

                }
            }
            else{
                GameOver();
            }
        }
    }
    void GameOver(){
        print("You lost!");
        FindObjectOfType<RoundScript>().GameOver();
    }

    void Update(){
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
}

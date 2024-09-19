using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Treecontroller : MonoBehaviour
{
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject rottenApple;

    public float speed = 10f;
    public float leftAndRightEdge = 5f;
    public float changeDirChnace = 0.1f;
   
    void Start()
    {
        InvokeRepeating(nameof(AppleInstantiater), 1, 1);
    }

    void AppleInstantiater()
    {
        Instantiate(ReturnCollectables(), transform.position, apple.transform.rotation);
    }

    GameObject ReturnCollectables(){
        int random = Random.Range(0, 10);
        return random % 2 == 0 ? rottenApple : apple;
    }

    void OnValidate(){
        Assert.IsNotNull(apple);
        Assert.IsNotNull(rottenApple);
    }

    void Update(){
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Chnaging direction
        if(pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed); //Move right
        }
        else if(pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed); //Move left
        }
        
    }

    void FixedUpdate(){
        if(Random.value < changeDirChnace){
            speed += 1; //Chnage direction
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavimento : MonoBehaviour
{
    Vector2 posIniziale;
    // Start is called before the first frame update
    void Start()
    {
       posIniziale = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameController.gameover){
        if(transform.position.x >= -1.14f)
        transform.position = new Vector2(transform.position.x - 0.0005f ,
        transform.position.y);
        else
        transform.position = posIniziale;
        }
       
    } 
}

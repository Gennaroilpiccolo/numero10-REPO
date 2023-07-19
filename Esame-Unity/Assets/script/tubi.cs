using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubi : MonoBehaviour
{
    bool giaContato = false ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameController.gameover){
              transform.position = new Vector2(transform.position.x - 0.0005f ,
        transform.position.y);
        }
         
        if(transform.position.x < -6)
        Destroy(gameObject);
        if(!giaContato && transform.position.x < -4){
            giaContato = true;
            punti.valorePunti += 1;
        }
    }
}

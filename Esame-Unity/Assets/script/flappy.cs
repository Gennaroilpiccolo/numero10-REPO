using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& !gameController.gameover)
        {
            rb.velocity = new Vector2 (0f, 7f);
        }
    
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        gameController.gameover = true;
        gameover.SetActive(true);
        restart.SetActive(true);
    }
}

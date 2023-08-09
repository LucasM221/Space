using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = gameObject.transform.parent.gameObject.GetComponent<Player>();
    }
    //quando eu começar a colidir
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            player.isJumping = false;
            Debug.Log("Colidiu!");
        }
    }
    //quando parar de colidir
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            player.isJumping = true;
            Debug.Log("Parou de colidir!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

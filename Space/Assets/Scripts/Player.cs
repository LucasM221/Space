using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    // rigidBody
    private Rigidbody2D rig;
    // Posição inicial do player
    private Vector3 posInicial;
    // Velocidade
    private float speed = 5;
    // Animator
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(0f, -2.3f, 0f);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(speed, rig.position.y);
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rig.velocity.y);

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.localScale.x > 0) 
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            Debug.Log("Tecla A pressionada.");
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            Debug.Log("Tecla D pressionada.");
        }
    }   
}

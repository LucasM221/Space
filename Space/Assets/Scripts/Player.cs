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
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(0, -2.3, 0);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

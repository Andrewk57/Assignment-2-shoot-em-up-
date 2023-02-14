using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveScript : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public float speed;
    
    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -speed);
    }
}

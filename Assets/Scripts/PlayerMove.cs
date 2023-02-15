using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
    
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -Vector3.right * speed * Time.deltaTime;
        }
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMoe : MonoBehaviour
{
    public Transform box;
    public Rigidbody2D rb;
    public float speed = .5f;

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

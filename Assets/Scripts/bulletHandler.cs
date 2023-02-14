using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHandler : MonoBehaviour
{
    public float am = 3f;
    private void Awake()
    {
        Destroy(gameObject, am);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletHandler : MonoBehaviour
{
    
    public float am = 3f;
    public float health = 3f;
    public static bool isDead = false;
    private float stored;
 
    private void Awake()
    {

        stored = health;
        Destroy(gameObject, am);
    }
    

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        //isDead = true;
        //Destroy(gameObject);

    }
   
}

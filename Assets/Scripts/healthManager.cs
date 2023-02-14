using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour
{
    public static bool isDead = false;
    private float health = 3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        takeDamage();
        Destroy(collision.gameObject);
    }
    void takeDamage()
    {
        health--;
        Debug.Log(health);
        if (health <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        isDead = true;
        Debug.Log("Dead");
        // turn death screen on and pause time/music
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class healthManager : MonoBehaviour
{
    public static bool isDead = false;
    private float health = 3f;
    public Image healthI;
    public GameObject winScreen;
    public GameObject deathScreen;
    private void Start()
    {
        isDead = false;
        winScreen.SetActive(false);
        deathScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "End")
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            winScreen.SetActive(false);
            Time.timeScale = 1f;    
        }
        takeDamage();

        if (collision.tag == "Enemy")
        {
            
            Destroy(collision.gameObject);
            Debug.Log("Destroyed bullet");
        }
        else
        {
            return;
        }
        //Destroy(collision.gameObject);
    }
    void takeDamage()
    {
        health--;
        Debug.Log(health);
        if (health == 2)
        {
            healthI.fillAmount = .2f;
        }
        if (health == 1)
        {
            healthI.fillAmount = .1f;
        }
        if (health <= 0)
        {
            healthI.fillAmount = 0f;
            Death();
        }
    }
    void Death()
    {
        isDead = true;
        Debug.Log("Dead");
        // turn death screen on and pause time/music
    }
    private void Update()
    {
        if (isDead == true)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            deathScreen.SetActive(false);
            //Time.timeScale = 1f;
        }
    }
    
}

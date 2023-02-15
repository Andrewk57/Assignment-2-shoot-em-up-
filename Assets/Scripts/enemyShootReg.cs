using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShootReg : MonoBehaviour
{
    public GameObject preFabRegBulletEnemy;
    public float fireRate;
    private float lastShot;
    public Transform bulletSpawnPoint;
    public float speed = 10f;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player Bullet")
        {
            
            explosion.Play();
            Debug.Log("Animation Played");
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastShot >= fireRate)
        {
            shoot();
            lastShot = Time.time;
        }
    }
    void shoot()
    {
        var bullet = Instantiate(preFabRegBulletEnemy, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * speed;
    }
}

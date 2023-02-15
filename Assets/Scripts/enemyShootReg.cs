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
    public Transform target; 
    public float shootingRange = 10.0f;
    public float checkFrequency = .5f;
    private bool canShoot = true;

    private void Start()
    {
        StartCoroutine(CheckDistance());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player Bullet")
        {
            
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Player Bullet"))
        {
            
            //explosion.Play();
            //Debug.Log("Explosion Played");
        }
    }
    IEnumerator CheckDistance()
    {
        while (true)
        {
            
            if (Vector2.Distance(transform.position, target.position) <= shootingRange)
            {
                canShoot = true;
            }
            yield return new WaitForSeconds(checkFrequency);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - lastShot >= fireRate && canShoot == true)
        {
            shoot();
            lastShot = Time.time;
            canShoot=false;
        }
    }
    void shoot()
    {
        var bullet = Instantiate(preFabRegBulletEnemy, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * speed;
    }
   
}

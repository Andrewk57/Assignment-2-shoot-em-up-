using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float speed = 10f;
    //public AudioSource shot;

    private void Update()
    {
        shot();
    }
    void shot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& ChangeSceneScript.isPaused == false)
        {

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * speed;
            //shot.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollerForBackground : MonoBehaviour
{
    private float speed = 4f;
    private Vector3 startArea;
    void Start()
    {
        startArea = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < 18.04082f)
        {
            transform.position = startArea;
        }
    }
}

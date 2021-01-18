﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        if(transform.position.x > 5 || transform.position.x < -5)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > 5 || transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}

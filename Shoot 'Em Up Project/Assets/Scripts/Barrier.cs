﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if(collision.collider.tag == "EnemyBullet")
        {
            health--;
            if (health == 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Barrier Destroyed.");

            }
        }
        */

        health--;
        if (health == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Barrier Destroyed.");

        }
    }
}

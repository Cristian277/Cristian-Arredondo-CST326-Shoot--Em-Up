using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Manager;
    public GameObject enemyBullet;
    public Transform shootingOffset;
    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("FireBullet", 1.0f, 2.0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Debug.Log("Ouch!");
            Destroy(this.gameObject);
            Debug.Log("Enemy is dead.");

            if (this.gameObject.name == "RedEnemy")
            {
                GameObject.Find("Manager").GetComponent<Manager>().increaseScore();
                Debug.Log("Red Enemy Killed.");
            }
            else if (this.gameObject.name == "BlueEnemy")
            {
                GameObject.Find("Manager").GetComponent<Manager>().increaseScore();
                Debug.Log("Blue Enemy Killed.");
            }else if(this.gameObject.name == "YellowEnemy")
            {
                GameObject.Find("Manager").GetComponent<Manager>().increaseScore();
                Debug.Log("Yellow Enemy Killed.");
            }else if(this.gameObject.name == "GreenEnemy")
            {
                GameObject.Find("Manager").GetComponent<Manager>().increaseScore();
                Debug.Log("Green Enemy Killed.");
            }
        }
    }

    void FireBullet()
    {
        Instantiate(enemyBullet,shootingOffset.position, Quaternion.identity);
    }

}

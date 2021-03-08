using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform enemyHolder;
    public GameObject Manager;
    public GameObject enemyBullet;
    public Transform shootingOffset;

    public float speed;
    public float fireRate = 0.0599f;
    public bool gameIsOver = false;

    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("MoveEnemy", 0.1f,0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    private void Update()
    {
        if (gameIsOver)
        {
            GameObject.Find("Manager").GetComponent<Manager>().gameOver();
            gameIsOver = false;
        }
    }

    void MoveEnemy()
    {
        enemyHolder.position += Vector3.right * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -9 || enemy.position.x > 9)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.5f;
                return;
            }

            if(Random.value > fireRate)
            {
                Instantiate(enemyBullet, enemy.transform.position, enemy.transform.rotation);
            }

            if(enemy.position.y <= -7)
            {
                Time.timeScale = 0f;
                gameIsOver = true;
            }
        }

        if(enemyHolder.childCount == 2)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.29f);
        }

        if(enemyHolder.childCount == 1)
        {
            CancelInvoke();
            Time.timeScale = 0;
            Debug.Log("Player wins!");
            Debug.Log("Press R to Restart.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            if (this.gameObject.name == "RedEnemy")
            {
                Destroy(this.gameObject);
                GameObject.Find("Manager").GetComponent<Manager>().increaseScoreRed();
                Debug.Log("Red Enemy Killed.");
            }
            else if (this.gameObject.name == "BlueEnemy")
            {
                Destroy(this.gameObject);
                GameObject.Find("Manager").GetComponent<Manager>().increaseScoreBlue();
                Debug.Log("Blue Enemy Killed.");
            }else if(this.gameObject.name == "YellowEnemy")
            {
                Destroy(this.gameObject);
                GameObject.Find("Manager").GetComponent<Manager>().increaseScoreYellow();
                Debug.Log("Yellow Enemy Killed.");
            }else if(this.gameObject.name == "GreenEnemy")
            {
                Destroy(this.gameObject);
                GameObject.Find("Manager").GetComponent<Manager>().increaseScoreGreen();
                Debug.Log("Green Enemy Killed.");
            }
        }

    void FireBullet()
    {
        Instantiate(enemyBullet,shootingOffset.position, Quaternion.identity);
    }

}

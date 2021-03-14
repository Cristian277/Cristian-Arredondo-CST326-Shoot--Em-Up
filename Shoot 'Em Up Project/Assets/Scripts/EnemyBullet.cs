using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float speed = 5;
    public GameObject Manager;

    // Start is called before the first frame update

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
        myRigidbody2D.velocity = Vector2.up * -speed;

        Debug.Log("Wwweeeeee");
    }

    private void Update()
    {
        if (myRigidbody2D.position.y <= -7)
        {
            Destroy(gameObject);
            Debug.Log("Bullet Destroyed");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            Destroy(this.gameObject);
            Destroy(collision.gameObject,1f);
            Debug.Log("Player is dead.");
            GameObject.Find("Manager").GetComponent<Manager>().gameOver();
        }
        else if (collision.collider.tag == "Barrier")
        {
            Destroy(this.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Manager;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
        Destroy(this.gameObject);
        Debug.Log("Enemy is dead.");
        Manager.GetComponent<Manager>().increaseScore();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Manager;
    public Transform shottingOffset;
    public int speed = 5;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);
      }

        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f,0f);

    }
}

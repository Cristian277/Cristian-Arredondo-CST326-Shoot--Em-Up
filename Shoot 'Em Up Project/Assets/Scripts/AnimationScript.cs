using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    public void setDeath()
    {
        animator.SetTrigger("enemyIsDead");
    }
}

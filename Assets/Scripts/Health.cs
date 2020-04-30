using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public Animator anim;
    public GameObject GameOver; 

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            AnimDeath();
            Die();
            GameOver.SetActive(true);
        }
    }

    public void Die () 
    {
        Destroy(gameObject,0.4f);

    }

     public void AnimDeath ()
    {
        anim.SetTrigger ("Death");
    }
}

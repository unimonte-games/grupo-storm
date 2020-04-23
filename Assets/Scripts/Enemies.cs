using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.down * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Player"))
        {
            Health health = hitInfo.GetComponent<Health>();
            if (health != null)
                {
                    health.TakeDamage(damage);
                }
            Destroy(gameObject);
        }
    }
}

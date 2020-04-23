using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer sprite;
    public float dashSpeed;
    public float dashSpeed1;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public float speed;
    private bool IsRight;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector2.down * speed;
        
       if (direction != 0)
       {
      
           if (dashTime <= 0)
           {
               direction = 0;
               dashTime = startDashTime;
               _rb.velocity = Vector2.zero;
           }
           else
           {
               dashTime -= Time.deltaTime;

               if (direction == 1)
               {
                   _rb.velocity = (Vector2.left + Vector2.up) * dashSpeed;
                   
                   
               }
               else if (direction == 2)
               {
                   _rb.velocity = (Vector2.right + Vector2.up) * dashSpeed;
                   
               }
           }
       }  
    }

    void Flip ()
    {
        sprite.flipY = !sprite.flipY;
    }

    public void LeftSide  ()
    {
        direction = 1;
        Flip();
    }

    public void RightSide ()
    {
        direction = 2;
        Flip();
    }

}

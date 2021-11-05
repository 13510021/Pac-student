using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.35f;
    Vector2 dest = Vector2.zero;
    Collider2D cor2D;
    public AudioClip C;

    
    void Start()
    {
        dest = transform.position;
        cor2D = GetComponent<Collider2D>();
        
        
    }

    
    void FixedUpdate()
    {
        
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
        
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.W) && validMove(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
            
            if (Input.GetKey(KeyCode.D) && validMove(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            
            if (Input.GetKey(KeyCode.S) && validMove(Vector2.down))
                dest = (Vector2)transform.position + Vector2.down;
            
            if (Input.GetKey(KeyCode.A) && validMove(Vector2.left))
                dest = (Vector2)transform.position + Vector2.left;
            
        }

        
        Vector2 dir = dest - (Vector2)transform.position;
        
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);

    }

    bool validMove(Vector2 dir)
    {
        
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
       

    }
}

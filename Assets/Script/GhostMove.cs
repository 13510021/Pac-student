using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    public AudioClip AC;
    public Transform[] waypoints;
    //record point
    int cur = 0;
    //move speed
    public float speed = 0.3f;


    void FixedUpdate()
    {
        //move
        if (transform.position != waypoints[cur].position)
        {

            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else cur = (cur + 1) % waypoints.Length;


        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    //destory pac-man
    void OnTriggerEnter2D(Collider2D co2)
    {
        if (co2.name == "Pac-Man")
        {
            Destroy(co2.gameObject);
            AudioSource.PlayClipAtPoint(AC, transform.localPosition);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour
{
    public AudioClip Hit;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-Man")
        {
            
            AudioSource.PlayClipAtPoint(Hit, transform.localPosition);
        }

        // Do Stuff...
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public AudioClip BC;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-Man")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(BC, transform.localPosition);
        }
            
        // Do Stuff...
    }
}

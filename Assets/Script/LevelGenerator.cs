using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;
    [SerializeField] private GameObject d;
    [SerializeField] private GameObject e;
    [SerializeField] private GameObject f;
    [SerializeField] private GameObject g;
    [SerializeField] private GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        //1
        Instantiate(a, new Vector2(-16, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-15, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-14, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-13, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-12, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-11, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-10, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-9, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-8, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-7, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-6, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-5, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-4, 7), Quaternion.Euler(0, 0, 0));
        Instantiate(t, new Vector2(-3, 7), Quaternion.Euler(0, 0, 0));

        //2
        Instantiate(b, new Vector2(-16, 6), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-14, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-13, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-12, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-11, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-10, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-9, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-8, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-7, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-6, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-5, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-4, 6), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, 6), Quaternion.Euler(0, 0, 90));

        //3
        Instantiate(b, new Vector2(-16, 5), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-14, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-13, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-12, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-11, 5), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-9, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-8, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-7, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-6, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-5, 5), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-4, 5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, 5), Quaternion.Euler(0, 0, 90));

        //4
        Instantiate(b, new Vector2(-16, 4), Quaternion.Euler(0, 0, 90));
        Instantiate(f, new Vector2(-15, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-14, 4), Quaternion.Euler(0, 0, 90));
        Instantiate(g, new Vector2(-13, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-12, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-11, 4), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, 4), Quaternion.Euler(0, 0, 90));
        Instantiate(g, new Vector2(-8, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-7, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-6, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-5, 4), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-4, 4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, 4), Quaternion.Euler(0, 0, 90));

        //5
        Instantiate(b, new Vector2(-16, 3), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 3), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-14, 3), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-13, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-12, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-11, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(e, new Vector2(-10, 3), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-9, 3), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-8, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-7, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-6, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-5, 3), Quaternion.Euler(0, 0, 180));
        Instantiate(e, new Vector2(-4, 3), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-3, 3), Quaternion.Euler(0, 0, 90));

        //6
        Instantiate(b, new Vector2(-16, 2), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-14, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-13, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-12, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-11, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-10, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-9, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-8, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-7, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-6, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-5, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-4, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-3, 2), Quaternion.Euler(0, 0, 0));

        //6
        Instantiate(b, new Vector2(-16, 1), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-14, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-13, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-12, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-11, 1), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-9, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-8, 1), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-7, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-6, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-5, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-4, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, 1), Quaternion.Euler(0, 0, 0));

        //7
        Instantiate(b, new Vector2(-16, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-14, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-13, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-12, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-11, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(e, new Vector2(-10, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-8, 0), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-7, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-6, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-5, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-4, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-3, 0), Quaternion.Euler(0, 0, 270));

        //8
        Instantiate(b, new Vector2(-16, -1), Quaternion.Euler(0, 0, 90));
        Instantiate(e, new Vector2(-15, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-14, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-13, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-12, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-11, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-10, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, -1), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-8, -1), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-7, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-6, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-5, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-4, -1), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, -1), Quaternion.Euler(0, 0, 270));

        // 9
        Instantiate(a, new Vector2(-16, -2), Quaternion.Euler(0, 0, 90));
        Instantiate(b, new Vector2(-15, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-14, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-13, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-12, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(a, new Vector2(-11, -2), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, -2), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, -2), Quaternion.Euler(0, 0, 90));
        Instantiate(c, new Vector2(-8, -2), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-7, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-6, -2), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-5, -2), Quaternion.Euler(0, 0, 270));
        Instantiate(g, new Vector2(-4, -2), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-3, -2), Quaternion.Euler(0, 0, 270));

        //10
        Instantiate(g, new Vector2(-16, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-15, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-14, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-13, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-12, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-11, -3), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, -3), Quaternion.Euler(0, 0, 90));
        Instantiate(c, new Vector2(-8, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-7, -3), Quaternion.Euler(0, 0, 180));
        Instantiate(d, new Vector2(-6, -3), Quaternion.Euler(0, 0, 180));
        Instantiate(c, new Vector2(-5, -3), Quaternion.Euler(0, 0, 180));
        Instantiate(g, new Vector2(-4, -3), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-3, -3), Quaternion.Euler(0, 0, 90));

        //11
        Instantiate(g, new Vector2(-16, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-15, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-14, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-13, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-12, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-11, -4), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, -4), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-8, -4), Quaternion.Euler(0, 0, 270));
        Instantiate(g, new Vector2(-7, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-6, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-5, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-4, -4), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-3, -4), Quaternion.Euler(0, 0, 0));

        //12
        Instantiate(g, new Vector2(-16, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-15, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-14, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-13, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-12, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(b, new Vector2(-11, -5), Quaternion.Euler(0, 0, 270));
        Instantiate(e, new Vector2(-10, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-9, -5), Quaternion.Euler(0, 0, 90));
        Instantiate(d, new Vector2(-8, -5), Quaternion.Euler(0, 0, 270));
        Instantiate(g, new Vector2(-7, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-6, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-5, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-4, -5), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-3, -5), Quaternion.Euler(0, 0, 90));

        //13
        Instantiate(b, new Vector2(-16, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-15, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-14, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-13, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(b, new Vector2(-12, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(a, new Vector2(-11, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(e, new Vector2(-10, -6), Quaternion.Euler(0, 0, 0));
        Instantiate(c, new Vector2(-9, -6), Quaternion.Euler(0, 0, 90));
        Instantiate(c, new Vector2(-8, -6), Quaternion.Euler(0, 0, 180));
        Instantiate(g, new Vector2(-7, -6), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-6, -6), Quaternion.Euler(0, 0, 90));
        Instantiate(g, new Vector2(-5, -6), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-4, -6), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-3, -6), Quaternion.Euler(0, 0, 0));

        //14
        Instantiate(g, new Vector2(-16, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-15, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-14, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-13, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-12, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-11, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(e, new Vector2(-10, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-9, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-8, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-7, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(d, new Vector2(-6, -7), Quaternion.Euler(0, 0, 90));
        Instantiate(g, new Vector2(-5, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-4, -7), Quaternion.Euler(0, 0, 0));
        Instantiate(g, new Vector2(-3, -7), Quaternion.Euler(0, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

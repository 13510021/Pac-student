using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void Loadlevel2()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

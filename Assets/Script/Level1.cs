using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    public void Loadlevel1()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

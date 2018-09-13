using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeToQuit : MonoBehaviour {
    
    void Start()
    {
        DontDestroyOnLoad(gameObject); //this makes the GameObject go through all the scenes. That means, this will work in every scene in the game.
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
            Debug.Log("Application has been quit!");
        }
    }
}

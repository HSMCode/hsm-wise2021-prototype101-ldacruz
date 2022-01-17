using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool gameOver;
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        // Load Prototype105 scene
        SceneManager.LoadScene(1);
    }
}

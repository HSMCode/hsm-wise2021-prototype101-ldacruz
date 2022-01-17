using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryControl : MonoBehaviour
{
    [SerializeField] FloatVariable playerScoreF;
    private GameManager _gameManagerScript;


    private void Start()
    {
        _gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (_gameManagerScript.score == 3)
        {
            Debug.Log("GameManager [1]: SIEG SIEG SIEG");
        }
        
        if (GameManagerStatic.ScoreStatic == 3)
        {
            Debug.Log("GameManagerStatic [2]: SIEG SIEG SIEG");
        }

        if (playerScoreF.value > 3)
        {
            Debug.Log("GameManager Scriptable Objects [3]: SIEG SIEG SIEG");
        }


    }
}

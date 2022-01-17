using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    // [1] Get the gameManagerScript for the DontDestoryOnLoad solution
    private GameManager _gameManagerScript;

    // [3] Set value fields for ScriptbleObject float and int variables
    [SerializeField] FloatVariable playerScoreF;
    [SerializeField] IntegerVariable playerScoreInt;

    private void Start()
    {
        // [1]
        _gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // [1] access variables
            _gameManagerScript.score++;
            _gameManagerScript.gameOver = true;
            Debug.Log("Dont Destroy onLoad GameManager Score: " + _gameManagerScript.score);

            // [2] Use static variables (those variables can't be used on in the editor)
            GameManagerStatic.ScoreStatic++;
            GameManagerStatic.GameOverStatic = true;
            Debug.Log("Static Game Manager Score: " + GameManagerStatic.ScoreStatic.ToString());

            // [3] access variable values of the linked scriptable objects
            playerScoreF.value++;
            playerScoreInt.value++;
            Debug.Log("Scriptable object value for FLOAT " + playerScoreF.value + " and for the INTEGER: " + playerScoreInt.value);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerController103 : MonoBehaviour
{
    public float jumpHeight = 1.0f;
    
    // variable for the update score timer script
    private UpdateScoreTimer _updateScoreTimerScript;

    
    void Start()
    {
        // get the script component and save it to the script variable
        _updateScoreTimerScript = GetComponent<UpdateScoreTimer>();
    }
    
    void Update()
    {
        // check for input space key down AND if the gameOver variable set on the UpdateScoreTimer script is still FALSE!
        if (Input.GetKeyDown(KeyCode.Space) && !_updateScoreTimerScript.gameOver)
        {
            transform.Translate(Vector3.up * jumpHeight);
            
            // call the method of the score script to increase the count on each "jump"
            _updateScoreTimerScript.UpdateMyScore();
        }
    }
}

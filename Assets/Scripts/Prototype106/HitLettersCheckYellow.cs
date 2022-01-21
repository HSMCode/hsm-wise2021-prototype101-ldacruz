using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLettersCheckYellow : MonoBehaviour
{
    public LetterStates letterStatesWord;
    public Letters letters;

    void Start()
    {
        
    }
    
    //Collider is yellow - other is blue
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered"); 

        if (letters.blueLetter.ToString().Contains(other.name))
        {
            Debug.Log("The Blue Letter matches the Yellow Letter with: " + gameObject.name + " and " + other.name);
            
            // Parent the Blue Letter as Child to Yellow Letter
            other.transform.SetParent(gameObject.transform);
        }

        if (letterStatesWord.letterStates.Contains(letters))
        {
            Debug.Log("The combined letter is part of the WORD with: " + letterStatesWord.ToString() + " and " + letters.ToString());
        }
        
    }
}

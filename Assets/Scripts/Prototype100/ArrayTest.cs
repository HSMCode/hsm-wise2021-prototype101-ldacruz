using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{

    public int dice = 0;
    // public int luckyNumber1 = 6;
    // public int luckyNumber2 = 12;
    // public int luckyNumber3 = 18;

    //public int[] luckyNumbers = new int [3];
    public int[] luckyNumbers = {6,12,18};

    // public GameObject[] myGameObjects;


    // Start is called before the first frame update
    void Start()
    {
        // luckyNumbers[0] = 6;
        // luckyNumbers[1] = 12;
        // luckyNumbers[2] = 18;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

           dice = Random.Range(1,21);
            
            if (dice == luckyNumbers[0] || dice == luckyNumbers[1] || dice == luckyNumbers[2]) 
            {
                Debug.Log(dice + " is a winner!");
            }       
            else
            {
                Debug.Log("You LOST!");
            }

        }
        
    }
}

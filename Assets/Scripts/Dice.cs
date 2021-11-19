using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int dice = 0;
    public int luckyNumber1 = 6;
    public int luckyNumber2 = 12;
    public int luckyNumber3 = 18;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           dice = Random.Range(1,21);
           // Debug.Log(dice);
            
            if (dice == luckyNumber1 || dice == luckyNumber2 || dice == luckyNumber3) 
            {
                Debug.Log(dice + " is a winner!");
            }
            // else if (dice == luckyNumber2) 
            // {
            //     Debug.Log("12 is another winner times 2");
            // }
            // else if (dice == luckyNumber3) 
            // {
            //     Debug.Log("18 is my favorite winner!");
            // }        
            else
            {
                Debug.Log("You LOST!");
            }

        }
    }
}

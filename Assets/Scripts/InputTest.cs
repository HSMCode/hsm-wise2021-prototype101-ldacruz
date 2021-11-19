using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public int numberOne = 1;
    public int numberTwo = 20;
    public int numberThree = 0;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Space key was pressed.");
            // numberOne = numberOne * numberTwo;
            // Debug.Log(numberOne);


            // this counts the variable below up 1 on each space press
            numberThree++;
            Debug.Log(numberThree);
            

            // this if statement is checked when space is pressed, only the true statements result in executing the statement in the curly brackets
            if (numberThree == 1) 
            {
                // when true do this
                Debug.Log("The if-statement was true: 1");
            }
            else if (numberThree == 2) 
            {
                // when true do this
                Debug.Log("The if-statement was true: 2");
            }
            else if (numberThree == 3) 
            {
                // when true do this
                Debug.Log("The if-statement was true: 3");
            }        
            else
            {
                // do this
                Debug.Log("The if-statements were false.");
            }

        }





    }
}
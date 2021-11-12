using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTest : MonoBehaviour
{
    // initialize various varibles with different data types and values here
    public int myFirstInteger = 10;
    public int mySecondInteger = 20;
    public int myThirdInteger;

    public GameObject myGameObject;

    public float myFirstFloat = 10.5f;
    public float mySecondFloat = 2665.5f;

    public string myFirstText = "Mein erster Text!";

    public bool myFirstBool;



    // Start is called before the first frame update
    void Start()
    {
        // output and calculation of various variables 
        Debug.Log(myFirstText + " " + myFirstFloat + " " + mySecondInteger);
        Debug.Log(myFirstText + myFirstFloat + mySecondInteger);

        myThirdInteger = myFirstInteger +  mySecondInteger;
        Debug.Log(myThirdInteger);

        myThirdInteger += 10; 

        Debug.Log("Neu Neu Neu " + myThirdInteger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

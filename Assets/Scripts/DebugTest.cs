using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // various debug log methods
        Debug.Log("Hello. I'm a debug log. Juhu!");
        Debug.LogError("ERROR - Hello. I'm a debug log. Juhu!");
        Debug.LogWarning("WARNING. I'm a debug log. Juhu!");
    }

    // Update is called once per frame
    void Update()
    {
        // This is a debug message, that will be displayed every frame, when uncommented.
        //  Debug.Log("Hello. Every frame, I say - Hello!"); 
    }
}

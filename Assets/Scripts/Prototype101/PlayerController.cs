using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // translates the player, up on the Y axis, with defined jumpHeight, ONCE at key press DOWN 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);
        }
        
        // // translates the player, up on the y axis, with defined jumpHeight, ONCE at key RELEASE
        // if (Input.GetKeyUp(KeyCode.Space))
        // {
        //     transform.Translate(Vector3.up * jumpHeight);  
        // }

    }
}

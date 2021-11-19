using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {

        // // move the cube each second with defined speed
        // transform.Translate(Vector3.right * Time.deltaTime * speed);

        // // move the cube once, on key press
        // if (Input.GetKeyDown(KeyCode.Space))
        // {

        //   transform.Translate(Vector3.right * speed);

        // }   

        // move the cube as long as the key is pressed down
        if (Input.GetKey(KeyCode.Space))
        {

          transform.Translate(Vector3.back * Time.deltaTime * speed);

        }   


    }
}

using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Fly : MonoBehaviour
{
    public float speed = 5.0f;
    
    void Update()
    {
        // translating the object with speed per second along the Vector3 -X or .left
        transform.Translate(Vector3.left * (speed * Time.deltaTime));
    }
}

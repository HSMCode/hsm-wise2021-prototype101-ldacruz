using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAutomatic : MonoBehaviour
{
    public GameObject invokedObject;

    void Start()
    {
        // this method calls the custom method "InvokeObject" starting after 5 seconds, and then every 2 seconds 
        InvokeRepeating("invokingObject", 5.0f, 2.0f);
    }
    
    private void invokingObject()
    {
        // clone prefab of game object
        Instantiate(invokedObject, transform.position, invokedObject.transform.rotation);
        Debug.Log("Object automatically invoked on repeat!");   
    }
}

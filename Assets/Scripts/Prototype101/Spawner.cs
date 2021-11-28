using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;

    void Update()
    {
        // to test the spawn method, use S to spawn an object
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawningObject();
        }
    }
    private void spawningObject()
    {
        // clone prefab of game object
        Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
        Debug.Log("Object spawned!");   
    }
}

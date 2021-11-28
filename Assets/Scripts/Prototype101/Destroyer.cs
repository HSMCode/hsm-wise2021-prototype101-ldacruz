using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // For a collision to work you need to have two objects with colliders (NOT triggers!)
    // One of those objects needs to have a Rigidbody attached (in our case, the Stone prefab)
    // If you want to use triggers, you need another method OnTriggerEnter(), check the Unity reference for details
    private void OnCollisionEnter(Collision hit)
    {
        // Make sure to destory the object, you want to destroy and check which object does the hit
        Debug.Log(gameObject.name + " just hit " + hit.gameObject.name);
        
        // We'll use the object tag to check if it needs to be destroyed. 
        // For this to work, you need to create and set the tag on the GameObject at the top in the inspector. 
        // Check the Stone prefab and look for the Destroyable tag at the top.
        if (hit.gameObject.CompareTag("Destroyable"))
        {
            // the hitting game object is destroyed
            Destroy(hit.gameObject);
            
            // for debug purposes we have the name of the destroyed object printed to console
            Debug.Log("<color=red>Destroyed " + hit.gameObject.name +"</color>");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSimple : MonoBehaviour
{
    private bool _canStart = true;
    public int countdown = 5;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && _canStart)
        {
            StartCoroutine(Countdown());
        }
        else if (Input.GetKeyDown(KeyCode.O) && !_canStart)
        {
            Debug.Log("Wait for Countdown to finish!");
        }
    }

    
    // // This Coroutine Countdown uses the WaitForSeconds method, to yield the routine for x seconds
    // // then the routine is resumed. There is no call until the WaitForSeconds is true.
    
    private IEnumerator Countdown()
    {
        // disable starting the routine again until it is running
        _canStart = false;
        
        Debug.Log("Waiting for seconds of countdown: " + countdown);
        
        // waits for x seconds until the routine is resumed
        yield return new WaitForSeconds(countdown);
    
        Debug.Log("Coroutine Done: Ready to count down again.");
        
        // after x seconds the routine can be started again
        _canStart = true;
    }
    
    // // ALTERNATIVE: This Coroutine Countdown uses a for loop to decrement the countdown. 
    // // With this way, we can e.g. print a Debug.Log each time the countdown is decremented. 
    
    // private IEnumerator Countdown()
    // {
    //     _canStart = false;
    //     Debug.Log("Simple Coroutine counting down from " + countdown);
    //     
    //     // for loop to decrement the countdown variable by 1 each frame (in this case each 10th of a second*)
    //     int i = countdown;
    //     for (; i > 0; i--)
    //     {
    //         Debug.Log("Ready in " + i);
    //         
    //         // *this waits a 20th of a second before the coroutine is resumed
    //         // (otherwise it would loop through the for-loop each frame instead of each 10th of a second)
    //         yield return new WaitForSeconds(0.1f);
    //         
    //         // this waits until the for loop is FALSE, in this case if i equals 0, then stops the routine
    //         yield return null;
    //     }
    //     
    //     _canStart = true;
    //     Debug.Log("Simple Coroutine countdown ready again.");
    // }
}



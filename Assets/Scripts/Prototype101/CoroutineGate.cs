using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineGate : MonoBehaviour
{
    [SerializeField] GameObject Gate;
    
    private bool _canLiftGate = true;
    private Vector3 _gateHeightDown;
    readonly Vector3 _gateHeightUp = new Vector3(0, 2, 0);
    public int countdown = 3;

    void Start()
    {
        _gateHeightDown = Gate.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && _canLiftGate)
        {
            StartCoroutine(MoveGate());
        }
        else if (Input.GetKeyDown(KeyCode.C) && !_canLiftGate)
        {
            Debug.Log("You can't lift the gate yet.");
        }
    }

    private IEnumerator MoveGate()
    {
        bool gateDown = true;
        bool gateUp = false;
        bool gateDesending = false;

        while (gateDown)
        {
            Debug.Log("Gate is lifting in 1 seconds from " + Time.time);
            _canLiftGate = false;

            yield return new WaitForSeconds(0.5f);

            gateDown = false;
            gateUp = true;
        }

        while (gateUp)
        {
            Debug.Log("Gate stays up for 3 seconds from " + Time.time);
            Gate.transform.position = (_gateHeightDown + _gateHeightUp);
            
            yield return new WaitForSeconds(countdown);
            
            gateUp = false;
            gateDesending = true;
        }
        
        while (gateDesending)
        {
            Debug.Log("Gate is closing with height " + Gate.transform.position.y + " at " + Time.time);
            Gate.transform.position += new Vector3(0,-0.01f,0);

            if (Gate.transform.position == _gateHeightDown)
            {
                gateDesending = false;
            }

            yield return null;
        }        
        
        yield return null;
        
        _canLiftGate = true;
        Debug.Log("Coroutine Done: Gate ready again.");
    }

}



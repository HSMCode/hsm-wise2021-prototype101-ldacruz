using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Assets.Scripts;
using UnityEngine;

public class PlayerController103Animator : MonoBehaviour
{
    public float jumpHeight = 1.25f;
    
    // How to create and use the Animator: 
    // 1st) Import a character model and animations
    // 2nd) Depending on the type of rig (easiest is a Standard Humanoid), you need to create a Character Avatar
    // 3rd) Create a new Animator Controller (Right Click/Create/Animator Controller); double click to open Animator window
    // 4th) Drop the animation clips from/for your rig into the Animator Controller
    // 5th) Set the needed parameters on the left side (Bool, Int, Float or Trigger), use cases include the following:
    //      Bool = If the animation should loop and has needs a controlled TRUE/FALSE state
    //      Int = To use for more complex distinctions, like directions (e.g. 4 directions instead of true/false)
    //      Float = You can pass speed to bind the animations or blend between different animations stages
    //      Trigger = For immediate animations to play, that don't need to be looped
    // 6th) Connect the animations depending on the desired behaviour (check Animator setup in this project for reference)
    // 7th) Adjust the code below if needed to call you Animator trigger parameters at the correct code positions. 
    
    // variable for the animator of the player character
    private Animator _animator;
    
    void Start()
    {
        // get the component attached to the game object and assign it to the animator variable
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Sets the trigger parameter "jump" of the Animator active, so the jump animation will play
            // The jump has no transition and exit time, to play immediately after button press,
            // after the animation clip is finished, the Animator state transitions back to Idle state.
            _animator.SetTrigger("jump");
            
            
            // Moves the player upwards
            transform.Translate(Vector3.up * jumpHeight);
        }
        
        // Hold down R to play the running animation as long as keycode is down
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Sets the bool of the animator named "running" to true
            // The animator now goes into the Run state. The "run" animation clip loops as long as needed (button is held down)
            _animator.SetBool("running", true);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            // Sets the bool of the Animator named "running" to false
            // The animation now exits and goes back to Idle state.
            _animator.SetBool("running", false);
        }

    }
}

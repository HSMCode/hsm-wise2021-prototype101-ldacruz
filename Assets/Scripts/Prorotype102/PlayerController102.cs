using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerController102 : MonoBehaviour
{
    public float jumpHeight = 1.0f;
    
    // variables to save the script references for audio and particle scripts assigned to the player
    private UseParticles _playParticlesScript;
    private PlayAudio _playAudioScript;

    // public audio clip to play for click effects
    public AudioClip clickSFX;

    // Start is called before the first frame update
    void Start()
    {
        // we get the script components and save them to the variables
        _playParticlesScript = GetComponent<UseParticles>();
        _playAudioScript = GetComponent<PlayAudio>();
    }

    // Update is called once per frame
    void Update()
    {
        // translates the player, up on the Y axis, with defined jumpHeight, ONCE at key press DOWN 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);

            // plays one random audio clip, this accesses and calls the method from the playaudio script
            _playAudioScript.PlayAudioClip();
            // starts to play the particles system
            _playParticlesScript.PlayingParticles(true);
            
            
            // this is an alternative to play audio, for short, click or ui sounds, where you don't need to know the length
            // the custom method shotAudio uses the input of the publicly assigned sfx clip on the player, to play on the audio script
            _playAudioScript.ShotAudio(clickSFX);
        }
        
        // translates the player, up on the y axis, with defined jumpHeight, ONCE at key RELEASE
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // this stops the particle system
            _playParticlesScript.PlayingParticles(false);
            
            // this emits the other particle system on key press UP - the red particles
            _playParticlesScript.EmitParticles();
        }

    }
}

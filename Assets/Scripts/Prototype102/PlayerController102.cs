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
    private AudioSource _playerAudioSource;

    // public audio clip to play for click effects
    public AudioClip clickSFX;
    
    // AUDIO ALTERNATIVE: public audio clip for simpler variant to be called and played at the player character
    public AudioClip jumpSFX;

    // Start is called before the first frame update
    void Start()
    {
        // we get the script components "Use Particles" and "PlayAudio" and save them to the variables
        _playParticlesScript = GetComponent<UseParticles>();
        _playAudioScript = GetComponent<PlayAudio>();
        
        // AUDIO ALTERNATIVE: instead of the scripts, we get the AudioSource component attached to the player game object
        _playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // translates the player, up on the Y axis, with defined jumpHeight, ONCE at key press DOWN 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);
            
            
            // starts to play the particles system
            _playParticlesScript.PlayingParticles(true);

            // plays one random audio clip, this accesses and calls the method from the playaudio script
            _playAudioScript.PlayAudioClip();
            
            // this is another option to play audio, for short, click or ui sounds, where you don't need to know the length
            // the custom method shotAudio uses the input of the publicly assigned sfx clip on the player, to play on the audio script
            _playAudioScript.ShotAudio(clickSFX);
            
            
            // AUDIO ALTERNATIVE: this plays the audio clip stored in the variable jumpSFX on the players audio source with PlayOneShot
            // PlayOneShot plays with the defined volume everytime, even if there is already another audio clip playing
            _playerAudioSource.PlayOneShot(jumpSFX, 1.0f);
            
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

using UnityEngine;


public class PlayAudio : MonoBehaviour
{
    // first is the variable to save the audio source reference
    // second is the variable for an array to assign the sfx sound clips
    private AudioSource _playerAudioSource;
    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        // We need to get the audio source component assigned on the player and save it in the variable.
        _playerAudioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioClip()
    {
        //the audio clip is only played, as long as there is no audio currently playing
        if (!_playerAudioSource.isPlaying)
        {
            // We create another int variable just inside this method, to randomly select one clip from the audio array
            int randomClip = Random.Range(0, clips.Length);

            // This sets the randomly picked array number on the audio source as current clip (to play)
            _playerAudioSource.clip = clips[randomClip];

            // The audio source 
            _playerAudioSource.Play();
        }
    }

    public void ShotAudio(AudioClip clip)
    {
        _playerAudioSource.PlayOneShot(clip, 1.0f);
    }
}

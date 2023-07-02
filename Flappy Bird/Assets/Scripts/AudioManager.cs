using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager Instance = null;
    public AudioSource audioSource;
    public AudioClip flapAudio;
    public AudioClip deadSound;
    public AudioClip scoreAudio;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFlap()
    {
        audioSource.PlayOneShot(flapAudio);
    }

    public void PlayDeadSound()
    {
        audioSource.PlayOneShot(deadSound);
    }

    public void ScoreAudio()
    {
        audioSource.PlayOneShot(scoreAudio);
    }
}

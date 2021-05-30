using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio current;
    private AudioSource _audioSource;

    void Start()
    {
        current = this;
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play(AudioClip audio)
    {
       _audioSource.PlayOneShot(audio);
    }
}

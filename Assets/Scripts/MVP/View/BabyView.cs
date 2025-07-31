using UnityEngine;

public class BabyView : View, IBabyView
{
    [SerializeField]
    private AudioSource _audioSource;
    public AudioSource audioSource
    {
        get
        {
            return _audioSource;
        }

    }

    public void PlayAudio(AudioClip clip)
    {
        if (audioSource != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
            
        }
    }


}

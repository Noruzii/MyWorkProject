
using UnityEngine;

public interface IBabyView
{
    AudioSource audioSource { get; }

    void PlayAudio(AudioClip clip);
}

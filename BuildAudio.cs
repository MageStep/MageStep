using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum soundType {Hurt, hitBadButton, hitGoodButton, Miss}

public class BuildAudio : MonoBehaviour
{
    public AudioClip[] clips;

    private AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();

        PlayClip(soundType.Hurt);
    }

    public void PlayClip(soundType type)
    {
        aud.PlayOneShot(clips[(int)type]);
    }
}

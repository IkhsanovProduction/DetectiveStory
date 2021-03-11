using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSound : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ShootSound()
    {
        audioSource.PlayOneShot(impact, 0.7F);
    }

}

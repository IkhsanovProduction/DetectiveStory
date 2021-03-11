using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioEnable : MonoBehaviour
{
    public AudioBehaviour source;
    void Start()
    {
        source.enabled = false;
    }

    public void AudioEnable()
    {
        source.enabled = true;
    }
}

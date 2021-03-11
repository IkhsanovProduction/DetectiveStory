using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScream : MonoBehaviour
{
    public AudioBehaviour source;
    void Start()
    {
        source.enabled = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LogicButton")
        {
            source.enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderZone : MonoBehaviour
{
    public Image image;
    public string tag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            image.enabled = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            image.enabled = false;
        }
    }

    void Start()
    {
        image.enabled = false;
    }
}

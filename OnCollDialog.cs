using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public string tag;
    public Canvas canvas;

    void Start()
    {
        canvas.enabled = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            canvas.enabled = true;
        }
    }
}

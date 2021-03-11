using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Where2_Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    public string tag;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            image.enabled = true;
        }
    }

    void Start()
    {
        image.enabled = false;
    }
}

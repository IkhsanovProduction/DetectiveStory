using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public int inz;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "finish")
        {
            SceneManager.LoadScene(inz);
        }
    }

    void OnCollisionExit(Collision other)
    {
       
    }
}

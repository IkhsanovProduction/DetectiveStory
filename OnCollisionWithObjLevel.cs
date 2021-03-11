using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisionWithObjLevel : MonoBehaviour
{
    public string tag;
    public int level;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            SceneManager.LoadScene(level);
        }
    }
}

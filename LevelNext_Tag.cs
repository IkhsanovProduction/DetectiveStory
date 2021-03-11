using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext_Tag : MonoBehaviour
{
    // Start is called before the first frame update

    public int level;
    public string tags;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tags)
        {
            SceneManager.LoadScene(level);
        }
    }

    void OnCollisionExit(Collision other)
    {

    }
}

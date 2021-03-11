using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public float wait_time = 5f;
    public int inz;

    void Start()
    {
        StartCoroutine(Wait_for_intro());
    }

    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(inz);
    }
}

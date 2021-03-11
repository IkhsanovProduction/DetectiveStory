using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputLevelSystem : MonoBehaviour
{
    public InputField input;
    public int level;

    void Update()
    {
        if (input.text == "3333")
        {
            SceneManager.LoadScene(level);
        }
    }
}

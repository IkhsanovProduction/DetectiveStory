using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool exit = false;

    public void Exits()
    {
        Application.Quit();
        exit = true;
    }

    public void Update()
    {
        if (exit == true) {
            Application.Quit();
        }
    }
}

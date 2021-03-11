using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HelpButton : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        canvas.enabled = false;
    }

    public void HelpButtonEnable()
    {
        canvas.enabled = true;
    }

    public void HelpButtonDisable()
    {
        canvas.enabled = false;
    }
}

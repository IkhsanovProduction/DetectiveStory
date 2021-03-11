using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;

    void GoodStart()
    {
        SceneManager.LoadScene(19);
    }

    void BadStart()
    {
        SceneManager.LoadScene(4);
    }

    void Update()
    {
        if (toggle1.isOn && toggle2.isOn)
        {
            GoodStart();
        }
        
        if(toggle2.isOn && toggle4.isOn)
        {
            GoodStart();
        }

        if (toggle1.isOn && toggle3.isOn)
        {
            BadStart();
        }
        

        if (toggle3.isOn && toggle4.isOn)
        {
            BadStart();
        }

        if (toggle1.isOn && toggle4.isOn)
        {
            BadStart();
        }

        if (toggle2.isOn && toggle3.isOn)
        {
            BadStart();
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class LightPlayer : MonoBehaviour
{
    public float lightTimeLeft = 100.0f;
    public Text lightText;

    public UnityEngine.Experimental.Rendering.Universal.Light2D lanternLight;

    private void Start()
    {
        lanternLight.enabled = false;
    }

    public void lanternLightButtTrue()
    {
        if(lanternLight.enabled == false)
        {
            lanternLight.enabled = true;
        }
    }

    public void lanternLightButtFalse()
    {
        if (lanternLight.enabled == true)
        {
            lanternLight.enabled = false;
        }
    }

    void Update()
    {
        if(lanternLight.enabled == true)
        {
            lightTimeLeft -= Time.deltaTime;
            lightText.text = (lightTimeLeft).ToString("0");
            if (lightTimeLeft < 0)
            {
                lanternLight.enabled = false;
            }
        }
    }
}

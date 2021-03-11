using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingLight : MonoBehaviour
{
    public float lightTimeLeft = 100.0f;
    //public Text lightText;

    public UnityEngine.Experimental.Rendering.Universal.Light2D lanternLight;

    private void Start()
    {
        lanternLight.enabled = true;
    }

 

    void Update()
    {
        if (lanternLight.enabled == true)
        {
            lightTimeLeft -= Time.deltaTime;
            
            if (lightTimeLeft < 0)
            {
                lanternLight.enabled = false;
            }
        }
    }
}

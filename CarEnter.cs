using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnter : MonoBehaviour
{
    public GameObject player;

    public Camera cameraCar;
    public AudioBehaviour source;

    private bool gets;

    public void Start()
    {
        cameraCar.enabled = false;
        source.enabled = false;
    }

    public void EnterCar()
    {
       
        player.SetActive(false);

        cameraCar.enabled = true;
        source.enabled = true;
        gets = true;
    }

    public void ExitCar()
    {
        player.SetActive(true);
        cameraCar.enabled = false;
        source.enabled = false;
    }

    public void Update()
    {
        if(gets == true)
        {
            cameraCar.enabled = true;

        }
    }
}

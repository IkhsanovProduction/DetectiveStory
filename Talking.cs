using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Talking : MonoBehaviour
{

    public TextMeshProUGUI textDisplay1;
    public TextMeshProUGUI textDisplay2;
    public TextMeshProUGUI textDisplayInspect;
    public TextMeshProUGUI textDisplayCar;



    // Start is called before the first frame update
    void Start()
    {
        textDisplay1.enabled = false;
        textDisplay2.enabled = false;
        textDisplayInspect.enabled = false;
        textDisplayCar.enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {


    }


    void OnCollisionEnter2D(Collision2D collision)
    {    
            if (collision.gameObject.tag == "SherifWoman")
            {

                textDisplay1.enabled = true;
                textDisplay2.enabled = true;
                textDisplayInspect.enabled = true;
            }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Car")
        {
            textDisplayCar.enabled = false;
        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Logic : MonoBehaviour
{
    public GameObject logicWall;
    public TextMeshProUGUI text;
    public InputField inpField;
    public GameObject logicButton;
    public Canvas canvas;
    
    

    void Start()
    {
       // logicWall.SetActive(false);
        canvas.enabled = false;
       
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LogicButton")
        {
           // logicWall.SetActive(true);
            text.text = "Я наполнил бензин. Доступ по коду: ";
            canvas.enabled = true;
            Destroy(gameObject);
            Destroy(logicButton);

        }
    }
}

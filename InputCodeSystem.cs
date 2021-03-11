using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputCodeSystem : MonoBehaviour
{
    public GameObject logicWall;
    public GameObject generator;
    public InputField input;
    public BoxCollider2D gener;
    //public GameObject wall;

    void Start()
    {
        logicWall.SetActive(false);
        gener = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(input.text == "5693")
        {
            logicWall.SetActive(true);
            gener.isTrigger = true;
        }
    }
}

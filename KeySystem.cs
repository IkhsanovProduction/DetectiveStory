using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeySystem : MonoBehaviour
{
    public TextMeshProUGUI key;
    public GameObject keyObject;
    private bool keyGetting = false;
    public Image door;
    public TextMeshProUGUI keyGetInfo;
    public GameObject wall;

    public void KeyGet()
    {
        keyGetting = true;
        keyObject.SetActive(false);
        keyGetInfo.enabled = true;
    }

    void Start()
    {
        wall.SetActive(false);
        door.enabled = false;
        keyGetInfo.enabled = false;
    }

    void Update()
    {
        
        if (keyGetInfo.enabled == true)
        {
            wall.SetActive(true);
           // door.enabled = true;
           
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ColliderZone")
        {
            door.enabled = true;
           
           
        }
    }
}

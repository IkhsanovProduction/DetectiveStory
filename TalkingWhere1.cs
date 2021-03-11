using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TalkingWhere1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay1;
    public TextMeshProUGUI textDisplay2;
    public Image image;

    public GameObject dialogBulletEnable;

  //  public TextMeshProUGUI textDisplayCar;
    private BoxCollider2D bXcoll;
    private BoxCollider2D shColl;
    public GameObject car;
    public GameObject sherif;
    public GameObject key;

    public Text text;
    public Text textup;
    private bool keyUp = false;
    private bool aptUp = false;
    private bool goodUp = false;

    public float lightTimeLeft = 5.0f;


    public void Start()
    {
      
        textDisplay1.enabled = false;
        textDisplay2.enabled = false;
        dialogBulletEnable.SetActive(false);
    //textDisplayCar.enabled = false;
    //  text.enabled = false;


    // car.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;


}

    public void Awake()
    {

        textup.enabled = false;
        text.enabled = false;
        

        car.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
   
      
       // image.enabled = true;



    }



    // Update is called once per frame
    void Update()
    {
        if (goodUp == true)
        {
            lightTimeLeft -= Time.deltaTime;
            if (lightTimeLeft < 0)
            {
                dialogBulletEnable.SetActive(false);
               // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
              
                textup.enabled = false;
            }
        }


    }


    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Car")
        {
            text.enabled = true;
            sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            if(keyUp == true)
            {
                text.text = "Вы взяли аптечку";
                dialogBulletEnable.SetActive(true);
                
               // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
             

                aptUp = true;
                
            }
        }



        if (collision.gameObject.tag == "SherifWoman")
        {
            car.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            textDisplay1.enabled = true;
            textDisplay2.enabled = true;
  

            if(aptUp == true)
            {
                
              //  textup.enabled = true;
                // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                textup.text = "Спасибо... Тебе нужно торопиться. Она там...Тебе нужно её убить.";
                text.enabled = true;
                Debug.Log("zuga");
            }


            // bXcoll.isTrigger = false;
           // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }

        if (collision.gameObject.tag == "Bullets")
        {
            

            textup.enabled = true;
            textup.text = "Спасибо... Тебе нужно торопиться. Она там...Тебе нужно её убить. Возьми это, она боится огня...";
            text.text = "Вы взяли гранату";
  
            image.enabled = true;
            goodUp = true;
            


            

            
            // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;



            // bXcoll.isTrigger = false;
            // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }

        if (collision.gameObject.tag == "Key")
        {
            text.text = "Вы взяли ключ";
            keyUp = true;
            Destroy(key);


        }

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Car")
        {
          //  textDisplayCar.enabled = false;
        }

    }
}

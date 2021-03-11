using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class en_TalkingWhere1 : MonoBehaviour
{
    public TextMeshProUGUI entextDisplay1;
    public TextMeshProUGUI entextDisplay2;
    public Image enimage;

    public GameObject endialogBulletEnable;

    //  public TextMeshProUGUI textDisplayCar;
    private BoxCollider2D enbXcoll;
    private BoxCollider2D enshColl;
    public GameObject encar;
    public GameObject ensherif;
    public GameObject enkey;

    public Text entext;
    public Text entextup;
    private bool enkeyUp = false;
    private bool enaptUp = false;
    private bool engoodUp = false;

    public float enlightTimeLeft = 5.0f;


    public void Start()
    {

        entextDisplay1.enabled = false;
        entextDisplay2.enabled = false;
        endialogBulletEnable.SetActive(false);
        //textDisplayCar.enabled = false;
        //  text.enabled = false;


        // car.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;


    }

    public void Awake()
    {

        entextup.enabled = false;
        entext.enabled = false;


        encar.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        ensherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;


        // image.enabled = true;



    }



    // Update is called once per frame
    void Update()
    {
        if (engoodUp == true)
        {
            enlightTimeLeft -= Time.deltaTime;
            if (enlightTimeLeft < 0)
            {
                endialogBulletEnable.SetActive(false);
                // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;

                entextup.enabled = false;
            }
        }


    }


    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Car")
        {
            entext.enabled = true;
            ensherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            if (enkeyUp == true)
            {
                entext.text = "You took aid kit.";
                endialogBulletEnable.SetActive(true);

                // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;


                enaptUp = true;

            }
        }



        if (collision.gameObject.tag == "SherifWoman")
        {
            encar.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            entextDisplay1.enabled = true;
            entextDisplay2.enabled = true;


            if (enaptUp == true)
            {

                //  textup.enabled = true;
                // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                entextup.text = "Thanks... You need to hurry. She's there...You need to kill her.";
                entext.enabled = true;
                Debug.Log("zuga");
            }


            // bXcoll.isTrigger = false;
            // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }

        if (collision.gameObject.tag == "Bullets")
        {


            entextup.enabled = true;
            entextup.text = "Thanks... You need to hurry. She's there...You need to kill her.";
            entext.text = "You took a grenade";

            enimage.enabled = true;
            engoodUp = true;






            // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;



            // bXcoll.isTrigger = false;
            // sherif.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }

        if (collision.gameObject.tag == "Key")
        {
            entext.text = "You took the key";
            enkeyUp = true;
            Destroy(enkey);


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



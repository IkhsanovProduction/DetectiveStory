using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCollider : MonoBehaviour
{
    
    
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
       }
  }

    void OnCollisionExit2D(Collision2D collision)
    {
       {
          
           //  gr.GetComponent<BoxCollider2D>().isTrigger = false;
          //  gr.gameObject.SetActive(true);
       }
    }
}

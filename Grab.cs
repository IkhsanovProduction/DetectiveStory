using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool grabbed;
    public bool zero;
    public bool grab = false;
    RaycastHit2D hit;
    public float distance = 2f;
    public Transform holdPoint;
    public float throwForce;
    public LayerMask notGrabbed;

    public void Grabs() {
        grab = true;

        if (grab == true)
        {
            if (!grabbed)
            {
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

                if (hit.collider != null && hit.collider.tag == "LogicBox")
                {
                    grabbed = true;
                }


            }
            else if (!Physics2D.OverlapPoint(holdPoint.position, notGrabbed))
            {
                grabbed = false;

                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwForce;
                }

            }





        }
    }

    // Update is called once per frame

    void Update()
    {
        
        if (grabbed)
        {
            hit.collider.gameObject.transform.position = holdPoint.position;
        }
    }

    
        
      
}

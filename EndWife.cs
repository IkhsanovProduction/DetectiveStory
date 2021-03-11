using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWife : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ToHell")
        {
            Destroy(gameObject);
        }
    }
}

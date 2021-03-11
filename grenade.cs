using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade : MonoBehaviour
{
    public int damage = 100;
   

    public GameObject impactEffect;

    public void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
           
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
         

        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

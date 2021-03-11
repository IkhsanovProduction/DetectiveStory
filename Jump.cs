using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float playerSpeed;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;

    public void Jumps()
    {
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run
        GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
    }
}

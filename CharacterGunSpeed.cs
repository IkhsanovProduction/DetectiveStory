using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGunSpeed : MonoBehaviour
{
    public float maxSpeed = 10f;
    private bool isFacingRight = true;

    private Animator anim;
    private Rigidbody2D rb;
    public Joystick joystick;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float move = joystick.Horizontal;
        anim.SetFloat("SpeedGun", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move > 0 && !isFacingRight)
            Flip(); 
        else if (move < 0 && isFacingRight)
            Flip(); 
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public float speed;
    private float inputVertical;

    public float maxSpeed = 10f;
    public float maxSprint = 20f;

    private bool isFacingRight = true;

    private Rigidbody2D rb;
    public Joystick joystick;

    public int level;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Sprint()
    {
        maxSpeed = 6f;
    }

    private void Update()
    {
        float move = joystick.Horizontal;
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move > 0 && !isFacingRight) {Flip(); }
        else if (move < 0 && isFacingRight) {Flip(); }

        if (move == 0){ maxSpeed = 3f; }
        if (Input.GetKey(KeyCode.Space)) {Sprint(); }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(level);
        }
    }
}

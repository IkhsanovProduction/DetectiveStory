using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CharacterControllerScript : MonoBehaviour
{
    //лестница
    [Header("StairsSystem")]
    public float speed;
    private float inputVertical;
    public float distance;
    public LayerMask whatIsLadder;
    public bool isClimbing;

    [Header("MaxSpeed")]
    public float maxSpeed = 10f;
    public float maxSprint = 20f;

    private bool isFacingRight = true;

    private Animator anim;
    private Rigidbody2D rb;
    public Joystick joystick;

    public int level;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Sprint()
    {
        anim.Play("DetectiveSprint");
        maxSpeed = 6f;
    }

    private void Update()
    {
        float move = joystick.Horizontal;
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move > 0 && !isFacingRight) {Flip();}
            
        else if (move < 0 && isFacingRight) {Flip();}

        if (move == 0)
        {
            anim.Play("DetectiveIdle");
            anim.StopPlayback();
            maxSpeed = 3f;
        }

        if (Input.GetKey(KeyCode.Space)) {Sprint();}
    }

    void FixedUpdate()
    {
        float upS = joystick.Vertical;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        if(hitInfo.collider != null)
        {
            if (upS > 0 || upS<0)
            {
                isClimbing = true;
            }
        
        }

        if (isClimbing == true && hitInfo.collider != null)
        {
            inputVertical = joystick.Vertical;//Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 5;
        }
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
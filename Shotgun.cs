using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Shotgun : MonoBehaviour
{
    //лестница
    public float speed;
    private float inputVertical;
    public float distance;
    public LayerMask whatIsLadder;
    public bool isClimbing;

    //переменная для установки макс. скорости персонажа
    public float maxSpeed = 10f;
    public float maxSprint = 20f;

    //переменная для определения направления персонажа вправо/влево
    private bool isFacingRight = true;

    //ссылка на компонент анимаций
    private Animator anim;
    private Rigidbody2D rb;
    public Joystick joystick;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Sprint()
    {
        anim.Play("DetectiveSprint");
        maxSpeed = 6f;
    }

    private void Update()
    {
        float move = joystick.Horizontal;
        anim.SetFloat("SpeedShotGun", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        //если нажали клавишу для перемещения вправо, а персонаж направлен влево
        if (move > 0 && !isFacingRight)
            //отражаем персонажа вправо
            Flip();
        //обратная ситуация. отражаем персонажа влево
        else if (move < 0 && isFacingRight)
            Flip();

        if (move == 0)
        {
            anim.Play("DetectiveShotgunIdle");
            anim.StopPlayback();
            maxSpeed = 3f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Sprint();

        }

        if (CrossPlatformInputManager.GetButtonDown("Fire1") && ammo > 0)
        {
            Shoot();
        }
        else
        {
            StopShoot();
        }
    }

    void FixedUpdate()
    {
        float upS = joystick.Vertical;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        if (hitInfo.collider != null)
        {
            if (upS > 0 || upS < 0)
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
        transform.Rotate(0f, 180f, 0f);
    }

    //-----------------------MonsterCollisionSystem----------------------------
    public int level;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(level);
        }

        if(collision.gameObject.tag == "Bullets")
        {
            ammo += 3;
        }
    }

    //---------------------------Shoot----------------------------------------
    [SerializeField]
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int ammo;
    public GameObject playe;
    public Collision2D coll;

    public void Shoot()
    {
        ammo = ammo - 1;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void StopShoot()
    {
        Debug.Log("StopShoot");
    }


    //------------------------ShootSound--------------------------------------
    public AudioClip impact;
    public AudioClip notBullets;
    AudioSource audioSource;

    public void ShootSound()
    {
        if(ammo > 0)
        {
            audioSource.PlayOneShot(impact, 0.7F);
        }
       
        else
        {
            audioSource.PlayOneShot(notBullets, 0.7F);
        }
    }
}


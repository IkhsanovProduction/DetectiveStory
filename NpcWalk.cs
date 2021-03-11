using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalk : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 500;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;
    private Animator anim;

    public bool _moveRight = true;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Use this for initialization
    public void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
    }


    // Update is called once per frame
    public void Update()
    {

        if (_moveRight)
        {
            anim.Play("FemaleRun");
            enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
        }

        if (enemyRigidBody2D.position.x >= _endPos)
            _moveRight = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NpcStop")
        {
            EnemySpeed = 0;
            anim.Play("FemaleIdle");
        }
    }
}

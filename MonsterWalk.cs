using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterWalk : MonoBehaviour
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

    public void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
    }

    public void Update()
    {
        if (_moveRight)
        {
            anim.Play("RunMonster");
            enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
            if (!_isFacingRight)
                Flip();
        }

        if (enemyRigidBody2D.position.x >= _endPos)
            _moveRight = false;

        if (!_moveRight)
        {
            anim.Play("RunMonster");
            enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
            if (_isFacingRight)
                Flip();
        }
        if (enemyRigidBody2D.position.x <= _startPos)
            _moveRight = true;
    }

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }
}

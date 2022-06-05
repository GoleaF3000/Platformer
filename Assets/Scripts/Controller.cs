using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _forceJump;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private bool _isGround; 

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) && _spriteRenderer.flipX == false)
        {
            _spriteRenderer.flipX = true;            
        }
        else if (Input.GetKey(KeyCode.D) && _spriteRenderer.flipX == true)
        {
            _spriteRenderer.flipX = false;            
        }

        if (Input.GetKey(KeyCode.A))
        {           
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {            
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W) && _isGround)
        {
            _rigidbody2D.velocity = transform.up * _forceJump;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ground ground))
        {
            _isGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ground ground))
        {
            _isGround = false;
        }
    }
}
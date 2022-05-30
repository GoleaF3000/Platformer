using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _forceJump;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private bool _isGround;
    private float _rotationY;
    private float _rotationLeft = 180;
    private float _rotationRight = 0;

    private void Start()
    {
        _rotationY = transform.rotation.y;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.A) && _rotationY == _rotationRight)
            {
                _rotationY = _rotationLeft;
            }
            else if (Input.GetKey(KeyCode.D) && _rotationY == _rotationLeft)
            {
                _rotationY = _rotationRight;
            }
            
            transform.rotation = Quaternion.Euler(0, _rotationY, 0);//создать корутину или метод для разворота, и создать систему событий
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
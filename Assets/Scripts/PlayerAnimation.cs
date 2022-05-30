using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animation;
    private float _speed = 0;    

    private void Start()
    {
        _animation = GetComponent<Animator>();        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _speed = 1;            
        }
        else
        {
            _speed = 0;            
        }

        _animation.SetFloat("Speed", _speed);
    }
}
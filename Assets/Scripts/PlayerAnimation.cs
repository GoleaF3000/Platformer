using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animation;
    private float _speed = 0;    

    private void Start()
    {
        _animation = GetComponent<Animator>();        
    }

    private void Update()
    {
        float move = 1;
        float stop = 0;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _speed = move;            
        }
        else
        {
            _speed = stop;            
        }

        _animation.SetFloat(Keys.PlayerAnimatorController.Parameters.Speed, _speed);;
    }
}

public static class Keys
{
    public static class PlayerAnimatorController
    {
        public static class Parameters
        {
            public const string Speed = "Speed";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _player;    

    private float _positionY = 0;
    private float _positionZ = -10;

    private void Start()
    {
        transform.position = new Vector3(_player.position.x, _positionY, _positionZ);
    }
   
    private void Update()
    {
        transform.position = new Vector3(_player.position.x, _positionY, _positionZ);
    }
}

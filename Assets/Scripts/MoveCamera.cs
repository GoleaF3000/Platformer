using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _player;   
    [SerializeField] private float _positionY;
    [SerializeField] private float _positionZ;

    private void Start()
    {
        transform.position = new Vector3(_player.position.x, _positionY, _positionZ);
    }
   
    private void Update()
    {
        transform.position = new Vector3(_player.position.x, _positionY, _positionZ);
    }
}
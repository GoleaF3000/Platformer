using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{   
    [SerializeField] private float _speed;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float rotationLeft = 180;
        float rotationRight = 0;

        if (collision.TryGetComponent(out PointLeft pointLeft))
        {
            TurnAround(rotationRight);
        }

        if (collision.TryGetComponent(out PointRight pointRight))
        {
            TurnAround(rotationLeft);
        }
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);        
    }

    private void TurnAround(float rotation)
    {        
        transform.rotation = Quaternion.Euler(0, rotation, 0);        
    }
}
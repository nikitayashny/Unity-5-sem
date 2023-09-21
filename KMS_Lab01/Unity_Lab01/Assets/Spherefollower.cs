using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFollower : MonoBehaviour
{
    public Transform target;
    public float speed = 5; 

    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        direction.y = 0;

        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
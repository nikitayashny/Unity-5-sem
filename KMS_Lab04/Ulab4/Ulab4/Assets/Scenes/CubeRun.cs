using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRun : MonoBehaviour
{
    public float speed = 1.0f; 
    public float maxZ = 5.0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 newPos = startPos;
        newPos.z += Mathf.PingPong(Time.time * speed, maxZ * 2.0f) - maxZ;

        transform.position = newPos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public float Distance;

    void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        Debug.DrawRay(ray.origin, ray.direction * Distance);

        if (Physics.Raycast(ray, Distance))
        {
            GetComponent<Renderer>().material.color = Color.red * 0.7f;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
    }
}

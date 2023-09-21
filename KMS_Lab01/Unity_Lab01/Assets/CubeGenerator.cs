using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    float minX;
    float maxX;
    float minZ;
    float maxZ;

    void Start()
    {
        MeshRenderer render = gameObject.GetComponent<MeshRenderer>();

        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;
    }

    void Update()
    {
        float newX = Random.Range(minX, maxX);
        float newZ = Random.Range(minZ, maxZ);
        float newY = gameObject.transform.position.y + 5;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateCube(newX, newY, newZ);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GenerateSphere(newX, newY, newZ);
        }
    }

    void GenerateCube(float x, float y, float z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.AddComponent<Rigidbody>();
    }

    void GenerateSphere(float x, float y, float z)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(x, y, z);
        sphere.AddComponent<Rigidbody>();

        Renderer sphereRenderer = sphere.GetComponent<Renderer>();
        sphereRenderer.material.color = Random.ColorHSV();
    }
}
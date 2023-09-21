using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Position : MonoBehaviour
{
    public float speed;
    public GameObject player;

    void Update()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        transform.position = new Vector3(posX + speed, posY, posZ);
    }
    void Start()
    {
        transform.position = player.transform.position - Vector3.forward * 10f;
    }
}

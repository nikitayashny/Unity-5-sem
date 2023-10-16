using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Stop : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Task_06_Car player = other.GetComponent<Task_06_Car>();

        if (player != null)
        {
            player.speed = 0f;
            player.objectRenderer.material.color = Color.red;

            Debug.Log("Your Score: " +  player.score);
        }
        
    }
}

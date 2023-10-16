using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond_Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Task_06_Car player = other.GetComponent<Task_06_Car>();

        if (player != null)
        {
            player.score++;
        }

    }
}
